using Microsoft.AspNetCore.Mvc;
using Proj.Core.BllInterfaces;
using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreShopWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController:ControllerBase
    {
        private readonly IRoleOperations operations;
        public RoleController(IRoleOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost]
        public async Task Add([FromBody] RoleModel model) => await operations.Add(model);
        [HttpDelete("{roleId}")]
        public async Task Delete([FromRoute] int roleId) => await operations.Delete(roleId);
        [HttpPut]
        public async Task Update([FromBody] RoleModel model) => await operations.Update(model);
        [HttpGet("{roleId}")]
        public async Task<RoleModel> Get([FromRoute] int roleId) => await operations.Get(roleId);
    }
}
