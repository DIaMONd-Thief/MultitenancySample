using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TenantSample.BL;
using TenantSample.Dal.Abstractions;

namespace TenantSample.Api.Controllers
{
    [Route("api/v1")]
    public class TestController : Controller
    {
        private readonly RepositoryUsingService _repositoryService;
        private readonly FactoryUsingService _factoryService;

        public TestController(RepositoryUsingService repositoryService, FactoryUsingService factoryService)
        {
            _repositoryService = repositoryService;
            _factoryService = factoryService;
        }

        [HttpGet("repo")]
        public IActionResult GetRepository()
        {
            return this.Ok(new {data = _repositoryService.Read()});
        }

        [HttpGet("factory")]
        public IActionResult GetFactory([FromQuery(Name = "tenant")] string tenant)
        {
            return Ok(new {data = _factoryService.Read(tenant)});
        }
    }
}
