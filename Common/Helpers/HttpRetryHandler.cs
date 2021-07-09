/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using log4net;
using RecurringIntegrationsScheduler.Common.JobSettings;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    public class HttpRetryHandler : DelegatingHandler
    {
        private int _retryAfter;
        private readonly Settings _settings;
        /// <summary>
        /// The log
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HttpRetryHandler(HttpMessageHandler innerHandler, Settings jobSettings)
            : base(innerHandler)
        {
            _settings = jobSettings;
            _retryAfter = _settings.RetryDelay;
            log4net.Config.XmlConfigurator.Configure();
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;
            for (int i = 0; i < _settings.RetryCount; i++)
            {
                response = await base.SendAsync(request, cancellationToken);
                if (response.IsSuccessStatusCode)
                {
                    return response;
                }
                if ((int)response.StatusCode == 429)
                {

                    i--; //Explicit ask for retry. Try until successful
                    if (response.Headers.Contains("Retry-After"))
                    {
                        _retryAfter = int.Parse(response.Headers.GetValues("Retry-After").FirstOrDefault());
                        Log.Warn($@"Job: {_settings.JobKey}. HttpRetryHandler.Task is being called.
ReqeuestUri: {request.RequestUri}
Response Status Code: {response.StatusCode} 
Priority-based throttling in action.
Requested delay (in seconds) between next request: {_retryAfter}");
                    }
                }
                if (_retryAfter > 0 && _settings.RetryCount > 1)
                {
                    Log.Warn($@"Job: {_settings.JobKey}. HttpRetryHandler.Task is being called.
Delaying next request for {_retryAfter} seconds...");
                    Thread.Sleep(TimeSpan.FromSeconds(_retryAfter));
                }
            }
            return response;
        }
    }

}
