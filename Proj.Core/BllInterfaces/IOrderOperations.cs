using Proj.Core.Entities;
using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
  public  interface IOrderOperations
    {
        Task Add(OrderModel model);
        Task Delete(OrderModel model);
        Task Delete(int id);
        Task Update(OrderModel model);
        Task<OrderModel> Get(int id);
    }
}
