using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using TenantSample.Dal.Abstractions;

namespace TenantSample.BL
{
    public class FactoryUsingService
    {
        private readonly ISomeRepositoryFactory _factory;
        private readonly ILogger _logger;

        public FactoryUsingService(ISomeRepositoryFactory factory, ILogger<FactoryUsingService> logger)
        {
            _factory = factory;
            _logger = logger;
        }

        public string Read(string tenantId)
        {
            _logger.LogInformation("I am information message with {tenantId}", tenantId);
            try
            {
                Exception exception = new InvalidOperationException("I am an exception!");
                exception.Data["x"] = "y";
                throw exception;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "Exception caught for {tenantId}", tenantId);
            }

            return _factory.Create(tenantId).Read();
        }
    }
}
