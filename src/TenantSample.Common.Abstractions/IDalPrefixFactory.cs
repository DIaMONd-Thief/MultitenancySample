﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TenantSample.Common.Abstractions
{
    public interface IDalPrefixFactory
    {
        string Create(string tenantId);
    }
}
