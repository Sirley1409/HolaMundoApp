﻿using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace App.Helpers.HttpMessageHandlers
{
    public class BaseAddressHandler : DelegatingHandler
    {
        public BaseAddressHandler()
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            return response;
        }
    }
}
