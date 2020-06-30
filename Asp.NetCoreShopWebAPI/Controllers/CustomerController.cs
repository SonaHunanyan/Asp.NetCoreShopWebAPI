using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proj.Core.BllInterfaces;
using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreShopWebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController:ControllerBase
    {
        private readonly ICustomerOperations operations;
        public CustomerController(ICustomerOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost("Add")]
        public async Task Add([FromBody] CustomerModel model) => await operations.Add(model);

        [HttpDelete("delete/{customerId}")]
        public async Task Delete([FromRoute] int customerId) => await operations.Delete(customerId);

        [HttpPut("Update")]
        public async Task Update([FromBody] CustomerModel model) => await operations.Update(model);

        [HttpGet("Get/{customerId}")]

        public async Task<CustomerModel> Get([FromRoute] int customerId) => await operations.Get(customerId);
    }
}
