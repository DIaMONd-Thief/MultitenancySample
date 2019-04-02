using System;
using System.Collections.Generic;
using System.Text;
using TenantSample.Dal.Abstractions;

namespace TenantSample.BL
{
    public class RepositoryUsingService
    {
        private readonly ISomeRepository _repository;

        public RepositoryUsingService(ISomeRepository repository)
        {
            _repository = repository;
        }

        public string Read()
        {
            return _repository.Read();
        }
    }
}
