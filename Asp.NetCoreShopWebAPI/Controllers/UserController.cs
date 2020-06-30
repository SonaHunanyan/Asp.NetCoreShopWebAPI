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
    public class UserController:ControllerBase
    {
        private readonly IUserOperations operations;
        public UserController(IUserOperations operations)
        {
            this.operations = operations;
        }
        [HttpPost]
        public async Task Add([FromBody] UserModel model) => await operations.Add(model);
        [HttpDelete("{userId}")]
        public async Task Delete([FromRoute] int userId) => await operations.Delete(userId);
        [HttpPut]
        public async Task Update([FromBody] UserModel model) => await operations.Update(model);
        [HttpGet("{userId}")]
        public async Task<UserModel> Get([FromRoute] int userId) => await operations.Get(userId);
    }
}
