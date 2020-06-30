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
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryOperations operations;
        public CategoryController(ICategoryOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost("addCategory")]
        public async Task Add([FromBody] CategoryModel model) => await operations.Add(model);

        [HttpDelete("delete/{categoryId}")]
        public async Task Delete([FromRoute] int categoryId) => await operations.Delete(categoryId);

        [HttpPut("Update")]
        public async Task Update([FromBody] CategoryModel model) => await operations.Update(model);

        [HttpGet("Get/{categoryId}")]
        public async Task<CategoryModel> Get([FromRoute] int categoryId) => await operations.Get(categoryId);
    }
}
