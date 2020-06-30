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
    public class PositionController:ControllerBase
    {
        private readonly IPositionOperations operations;
        public PositionController(IPositionOperations operations)
        {
            this.operations = operations;
        }

        [HttpPost("Add")]
        public async Task Add([FromBody] PositionModel model) => await operations.Add(model);

        [HttpDelete("Delete/{positionId}")]
        public async Task Delete([FromRoute] int positionId) => await operations.Delete(positionId);
        [HttpPut("Update")]
        public async Task Update([FromBody] PositionModel model) => await operations.Update(model);

        [HttpGet("Get/{positionId}")]
        public async Task Get([FromRoute] int positionId) => await operations.Get(positionId);
    }
}
