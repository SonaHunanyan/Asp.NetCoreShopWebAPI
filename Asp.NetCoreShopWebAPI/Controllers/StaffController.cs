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
    public class StaffController:ControllerBase
    {
        private readonly IStaffOperations operations;
        public StaffController(IStaffOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost("Add")]
        public async Task Add([FromBody] StaffModel model) => await operations.Add(model);

        [HttpDelete("Delete/{staffId}")]
        public async Task Delete([FromRoute] int staffId) => await operations.Delete(staffId);

        [HttpPut("Update")]
        public async Task Update([FromBody] StaffModel model) => await operations.Update(model);

        [HttpGet("Get/{staffId}")]
        public async Task<StaffModel> Get([FromRoute] int staffId) => await operations.Get(staffId);
    }
}
