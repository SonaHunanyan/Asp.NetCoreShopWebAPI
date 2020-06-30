using Proj.Core.Entities;
using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
   public interface IOrderProductOperations
    {
        Task Add(OrderProductModel model);
        Task Delete(OrderProductModel model);
        Task Delete(int orderId, int productId);
        Task Update(OrderProductModel model);
        Task<OrderProductModel> Get(int orderId, int productId);
    }
}
