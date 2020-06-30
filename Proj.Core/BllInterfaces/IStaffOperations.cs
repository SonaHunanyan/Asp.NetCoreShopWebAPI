using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
  public  interface IStaffOperations
    {
        Task Add(StaffModel model);
        Task Delete(StaffModel model);
        Task Delete(int id);
        Task Update(StaffModel model);
        Task<StaffModel> Get(int id);
    }
}
