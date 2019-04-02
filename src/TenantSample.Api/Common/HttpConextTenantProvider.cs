using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using TenantSample.Common.Abstractions;

namespace TenantSample.Api.Common
{
    public class HttpConextTenantProvider : ITenantIdProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public HttpConextTenantProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string GetTenantId()
        {
            return _contextAccessor.HttpContext.Request.Headers.ContainsKey("X-TenantId")
                ? _contextAccessor.HttpContext.Request.Headers["X-TenantId"].First()
                : "Default";
        }
    }
}
