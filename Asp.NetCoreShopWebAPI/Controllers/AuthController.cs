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
    public class AuthController:ControllerBase
    {
        private readonly IAuthenticationOperations authentication;
        public AuthController(IAuthenticationOperations authentication)
        {
            this.authentication = authentication;
        }
        [HttpPost("Authenfication")]
        public async Task<string> Authentification([FromBody] LoginModel model) => await authentication.Authentication(model);
    }
}
