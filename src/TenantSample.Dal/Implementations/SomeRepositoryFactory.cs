using System;
using System.Collections.Generic;
using System.Text;
using TenantSample.Common.Abstractions;
using TenantSample.Dal.Abstractions;

namespace TenantSample.Dal.Implementations
{
    public class SomeRepositoryFactory:ISomeRepositoryFactory
    {
        private readonly string _context; // stub for connection string for PostgreSQL or db context for DDB.
        private readonly IDalPrefixFactory _prefixFactory;

        public SomeRepositoryFactory(string context, IDalPrefixFactory prefixFactory)
        {
            _context = context;
            _prefixFactory = prefixFactory;
        }

        public ISomeRepository Create(string tenantId)
        {
            return new SomeRepository(_context, _prefixFactory.Create(tenantId));
        }
    }
}
