using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proj.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreShopWebAPI
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
   
    public class BrandController:ControllerBase
    {
        private readonly IBrandOperations operations;
        public BrandController(IBrandOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost("addBrand")]
        public async Task Add([FromBody] BrandModel model) => await operations.Add(model);

        [HttpDelete("delete/{brandId}")]
        public async Task Delete([FromRoute] int bramdId) => await operations.Delete(bramdId);

        [HttpPut("Update")]
        public async Task Update([FromBody] BrandModel model) => await operations.Update(model);

        [HttpGet("Get/{brandId}")]
        public async Task<BrandModel> Get([FromRoute] int brandId) => await operations.Get(brandId);
    }
}
