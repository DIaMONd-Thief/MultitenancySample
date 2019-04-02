using System;
using System.Collections.Generic;
using System.Text;
using TenantSample.Dal.Abstractions;

namespace TenantSample.Dal.Implementations
{
    public class SomeRepository : ISomeRepository
    {
        private readonly string _context;
        private readonly string _prefix;

        public SomeRepository(string context, string prefix)
        {
            _context = context;
            _prefix = prefix;
        }

        public string Read()
        {
            return $"Read from {_prefix}Table: {_context}";
        }
    }
}
