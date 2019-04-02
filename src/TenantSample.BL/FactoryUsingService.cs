using System;
using System.Collections.Generic;
using System.Text;
using TenantSample.Dal.Abstractions;

namespace TenantSample.BL
{
    public class FactoryUsingService
    {
        private readonly ISomeRepositoryFactory _factory;

        public FactoryUsingService(ISomeRepositoryFactory factory)
        {
            _factory = factory;
        }

        public string Read(string tenantId)
        {
            return _factory.Create(tenantId).Read();
        }
    }
}
