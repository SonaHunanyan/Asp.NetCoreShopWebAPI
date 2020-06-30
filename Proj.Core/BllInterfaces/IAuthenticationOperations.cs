using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
    public interface IAuthenticationOperations
    {
        Task<string> Authentication(LoginModel loginModel);
    }
}
