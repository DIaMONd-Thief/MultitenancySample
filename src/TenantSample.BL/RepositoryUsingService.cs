using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using TenantSample.Dal.Abstractions;

namespace TenantSample.BL
{
    public class RepositoryUsingService
    {
        private readonly ISomeRepository _repository;
        private readonly ILogger _logger;

        public RepositoryUsingService(ISomeRepository repository, ILogger<RepositoryUsingService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public string Read()
        {
            _logger.LogDebug("I am debug message.");
            _logger.LogInformation("I am information message.");
            _logger.LogWarning("I am warning message.");
            _logger.LogError("I am error message.");

            try
            {
                try
                {
                    Exception testException1 = new ArgumentNullException("42");
                    testException1.Data["prop1"] = "value1";
                    testException1.Data["prop2"] = new {A = 1, B = "abc"};

                    throw testException1;
                }
                catch (ArgumentNullException ex)
                {
                    throw new InvalidOperationException("Outer exception", ex);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Complex exception intercepted.");
            }

            return _repository.Read();
        }
    }
}
