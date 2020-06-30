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
    public class StockController:ControllerBase
    {
        private readonly IStockOperations operations;
        public StockController(IStockOperations operations)
        {
            this.operations = operations;
        }
        [HttpPost("Add")]
        public async Task Add([FromBody] StockModel model) => await operations.Add(model);

        [HttpDelete("Delete/{storeId}/{productId}")]

        public async Task Delete([FromRoute] int storeId, [FromRoute] int productId) => await operations.Delete(storeId, productId);

        [HttpPut("Update")]
        public async Task Update([FromBody] StockModel model) => await operations.Update(model);

        [HttpGet("Get/{storeId}/{productId}")]
        public async Task<StockModel> Get([FromRoute] int storeId, [FromRoute] int productId) => await operations.Get(storeId, productId);
    }
}
