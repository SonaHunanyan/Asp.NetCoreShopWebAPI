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
    public class ProductController:ControllerBase
    {
        private readonly IProductOperations operations;
        public ProductController(IProductOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost("Add")]
        public async Task Add([FromBody] ProductModel model) => await operations.Add(model);

        [HttpDelete("Delete/{productId}")]
        public async Task Delete([FromRoute] int productId) => await operations.Delete(productId);

        [HttpPut("Update")]
        public async Task Update([FromBody] ProductModel model) => await operations.Update(model);

        [HttpGet("Get/{productId}")]
        public async Task<ProductModel> Get([FromRoute] int productId) => await operations.Get(productId);

    }
}
