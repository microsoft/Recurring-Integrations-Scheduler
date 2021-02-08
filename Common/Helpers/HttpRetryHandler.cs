/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    public class HttpRetryHandler : DelegatingHandler
    {
        private readonly int maxRetries;
        private int delayBetweenRetries;

        public HttpRetryHandler(HttpMessageHandler innerHandler, int retries = 3, int delay = 1)
            : base(innerHandler)
        {
            maxRetries = retries;
            delayBetweenRetries = delay;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;
            for (int i = 0; i < maxRetries; i++)
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
                        delayBetweenRetries = int.Parse(response.Headers.GetValues("Retry-After").FirstOrDefault());
                    }
                }
                if (delayBetweenRetries > 0 )
                {
                    Thread.Sleep(TimeSpan.FromSeconds(delayBetweenRetries));
                }
            }
            return response;
        }
    }

}
