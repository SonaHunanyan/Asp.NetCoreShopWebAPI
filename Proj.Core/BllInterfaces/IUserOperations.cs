using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
  public  interface IUserOperations
    {
        Task Add(UserModel model);

        Task Delete(UserModel model);
        Task Delete(int id);
        Task Update(UserModel model);
        Task<UserModel> Get(int id);

    }
}
