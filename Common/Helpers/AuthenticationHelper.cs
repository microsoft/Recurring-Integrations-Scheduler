/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using RecurringIntegrationsScheduler.Common.JobSettings;
using System;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using UrlCombineLib;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    /// <summary>
    /// Authentication helper class
    /// </summary>
    internal class AuthenticationHelper
    {
        private readonly Settings _settings;
        private string _authorizationHeader;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationHelper"/> class.
        /// </summary>
        /// <param name="jobSettings">Job settings</param>
        public AuthenticationHelper(Settings jobSettings)
        {
            _settings = jobSettings;
        }

        /// <summary>
        /// Authorization result property.
        /// </summary>
        /// <value>
        /// Authentication result.
        /// </value>
        private Microsoft.Identity.Client.AuthenticationResult AuthenticationResult { get; set; }
        private Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult AuthenticationResultADAL { get; set; }

        /// <summary>
        /// Sets authorization header.
        /// </summary>
        /// <returns>Authorization header</returns>
        private async Task<string> AuthorizationHeader()
        {
            if (!string.IsNullOrEmpty(_authorizationHeader) && (DateTime.UtcNow.AddSeconds(60) < AuthenticationResult.ExpiresOn))
            {
                return _authorizationHeader;
            }
            IConfidentialClientApplication appConfidential;
            IPublicClientApplication appPublic;
            var aosUriAuthUri = new Uri(_settings.AosUri);
            string authority = UrlCombine.Combine(_settings.AzureAuthEndpoint, _settings.AadTenant);
            string[] scopes = new string[] { UrlCombine.Combine(aosUriAuthUri.AbsoluteUri,  ".default") };

            if (_settings.UseServiceAuthentication)
            {
                appConfidential = ConfidentialClientApplicationBuilder.Create(_settings.AadClientId.ToString())
                    .WithClientSecret(_settings.AadClientSecret)
                    .WithAuthority(authority)
                    .Build();
                AuthenticationResult = await appConfidential.AcquireTokenForClient(scopes).ExecuteAsync();
            }
            else
            {
                appPublic = PublicClientApplicationBuilder.Create(_settings.AadClientId.ToString())
                    .WithAuthority(authority)
                    .Build();
                var accounts = await appPublic.GetAccountsAsync();

                if (accounts.Any())
                {
                    AuthenticationResult = await appPublic.AcquireTokenSilent(scopes, accounts.FirstOrDefault()).ExecuteAsync();
                }
                else
                {
                    using var securePassword = new SecureString();
                    foreach (char c in _settings.UserPassword)
                    {
                        securePassword.AppendChar(c);
                    }
                    AuthenticationResult = await appPublic.AcquireTokenByUsernamePassword(scopes, _settings.UserName, securePassword).ExecuteAsync();
                }
            }
            return _authorizationHeader = AuthenticationResult.CreateAuthorizationHeader();
        }

        private async Task<string> AuthorizationHeaderADAL()
        {
            if (!string.IsNullOrEmpty(_authorizationHeader) &&
                (DateTime.UtcNow.AddSeconds(60) < AuthenticationResultADAL.ExpiresOn)) return _authorizationHeader;

            var uri = new UriBuilder(_settings.AzureAuthEndpoint)
            {
                Path = _settings.AadTenant
            };

            var aosUriAuthUri = new Uri(_settings.AosUri);
            string aosUriAuth = aosUriAuthUri.GetLeftPart(UriPartial.Authority);

            var authenticationContext = new AuthenticationContext(uri.ToString(), validateAuthority: false);

            if (_settings.UseServiceAuthentication)
            {
                var credentials = new Microsoft.IdentityModel.Clients.ActiveDirectory.ClientCredential(_settings.AadClientId.ToString(), _settings.AadClientSecret);

                AuthenticationResultADAL = await authenticationContext.AcquireTokenAsync(aosUriAuth, credentials);
            }
            else
            {
                var credentials = new UserPasswordCredential(_settings.UserName, _settings.UserPassword);

                AuthenticationResultADAL = await authenticationContext.AcquireTokenAsync(aosUriAuth, _settings.AadClientId.ToString(), credentials);
            }

            return _authorizationHeader = AuthenticationResultADAL.CreateAuthorizationHeader();
        }

        /// <summary>
        /// Gets valid authentication header
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public async Task<string> GetValidAuthenticationHeader()
        {
            if (_settings.UseADAL)
            {
                _authorizationHeader = await AuthorizationHeaderADAL();
            }
            else
            {
                _authorizationHeader = await AuthorizationHeader();
            }
            return _authorizationHeader;
        }
    }
}