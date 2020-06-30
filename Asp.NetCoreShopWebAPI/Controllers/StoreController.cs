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
    public class StoreController:ControllerBase
    {
        private readonly IStoreOperations operations;
        public StoreController(IStoreOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost("Add")]
        public async Task Add([FromBody] StoreModel model) => await operations.Add(model);

        [HttpDelete("Delete/{storeId}")]
        public async Task Delete([FromRoute] int storeId) => await operations.Delete(storeId);

        [HttpPut("Update")]
        public async Task Update([FromBody] StoreModel model) => await operations.Update(model);

        [HttpGet("Get/{storeId}")]
        public async Task<StoreModel> Get([FromRoute] int storeId) => await operations.Get(storeId);
    }
}
