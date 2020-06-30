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
    public class OrderProductController:ControllerBase
    {
        private readonly IOrderProductOperations operations;
        public OrderProductController(IOrderProductOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost("Add")]
        public async Task Add([FromBody] OrderProductModel model) => await operations.Add(model);

        [HttpDelete("delete/{orderId}/{productId}")]
        public async Task Delete([FromRoute] int orderId, [FromRoute] int productId) => await operations.Delete(orderId, productId);

        [HttpPut("Update")]
        public async Task Update([FromBody] OrderProductModel model) => await operations.Update(model);

        [HttpGet("Get/{orderId}/{productId}")]
        public async Task<OrderProductModel> Get([FromRoute] int orderId, [FromRoute] int productId) => await operations.Get(orderId, productId);
    }
}
