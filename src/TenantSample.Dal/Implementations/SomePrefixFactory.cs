using System;
using System.Collections.Generic;
using System.Text;
using TenantSample.Common.Abstractions;

namespace TenantSample.Dal.Implementations
{
    public class SomePrefixFactory : IDalPrefixFactory
    {
        public string Create(string tenantId)
        {
            return tenantId + ".v1.";
        }
    }
}
