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
    public class OrderOperations:ControllerBase
    {
        private readonly IOrderOperations operations;
        public OrderOperations(IOrderOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost("Add")]
        public async Task Add([FromBody] OrderModel model) => await operations.Add(model);

        [HttpDelete("Delete/{orderId}")]
        public async Task Delete([FromRoute] int orderId) => await operations.Delete(orderId);

        [HttpPut("Update")]
        public async Task Update([FromBody] OrderModel model) => await operations.Update(model);

        [HttpGet("Get/{orderId}")]
        public async Task<OrderModel> Get([FromRoute] int orderId) => await operations.Get(orderId);
    }
}
