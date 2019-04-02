using System;
using System.Collections.Generic;
using System.Text;

namespace TenantSample.Dal.Abstractions
{
    public interface ISomeRepositoryFactory
    {
        ISomeRepository Create(string tenantId);
    }
}
