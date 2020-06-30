using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
  public  interface IRoleOperations
    {
        Task Add(RoleModel model);

        Task Delete(RoleModel model);
        Task Delete(int id);
        Task Update(RoleModel model);
        Task<RoleModel> Get(int id);
    }
}
