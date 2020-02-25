/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Microsoft.Identity.Client;
using RecurringIntegrationsScheduler.Common.JobSettings;
using System;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    /// <summary>
    /// Authentication helper class
    /// </summary>
    internal class AuthenticationHelper
    {
        private readonly Settings _settings;
        private string _authorizationHeader;
        private const string AuthEndpoint = "https://login.microsoftonline.com/";

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
        private AuthenticationResult AuthenticationResult { get; set; }

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
            string authority = AuthEndpoint + _settings.AadTenant;
            string[] scopes = new string[] { aosUriAuthUri.AbsoluteUri +  ".default" };

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

        /// <summary>
        /// Gets valid authentication header
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public async Task<string> GetValidAuthenticationHeader()
        {
            _authorizationHeader = await AuthorizationHeader();
            return _authorizationHeader;
        }
    }
}