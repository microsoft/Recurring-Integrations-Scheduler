/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Microsoft.IdentityModel.Clients.ActiveDirectory;
using RecurringIntegrationsScheduler.Common.JobSettings;
using System;
using System.Net.Http.Headers;
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
            if (!string.IsNullOrEmpty(_authorizationHeader) &&
                (DateTime.UtcNow.AddSeconds(60) < AuthenticationResult.ExpiresOn)) return _authorizationHeader;

            var uri = new UriBuilder(_settings.AzureAuthEndpoint)
            {
                Path = _settings.AadTenant
            };

            var authenticationContext = new AuthenticationContext(uri.ToString());

            if (_settings.UseServiceAuthentication)
            {
                var credentials = new ClientCredential(_settings.AadClientId.ToString(), _settings.AadClientSecret);

                AuthenticationResult = await authenticationContext.AcquireTokenAsync(_settings.AosUri, credentials);
            }
            else
            {
                var credentials = new UserPasswordCredential(_settings.UserName, _settings.UserPassword);

                AuthenticationResult = await authenticationContext.AcquireTokenAsync(_settings.AosUri, _settings.AadClientId.ToString(), credentials);
            }

            return _authorizationHeader = AuthenticationResult.CreateAuthorizationHeader();
        }

        /// <summary>
        /// Gets valid authentication header
        /// </summary>
        /// <returns>
        /// AuthenticationHeaderValue object
        /// </returns>
        public async Task<AuthenticationHeaderValue> GetValidAuthenticationHeader()
        {
            _authorizationHeader = await AuthorizationHeader();
            return ParseAuthenticationHeader(_authorizationHeader);
        }

        /// <summary>
        /// Parses authentication header.
        /// </summary>
        /// <param name="authorizationHeader">Authorization header.</param>
        /// <returns>AuthenticationHeaderValue object</returns>
        private static AuthenticationHeaderValue ParseAuthenticationHeader(string authorizationHeader)
        {
            var split = authorizationHeader.Split(' ');
            var scheme = split[0];
            var parameter = split[1];
            return new AuthenticationHeaderValue(scheme, parameter);
        }
    }
}