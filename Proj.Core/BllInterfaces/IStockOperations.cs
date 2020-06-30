using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
   public interface IStockOperations
    {
        Task Add(StockModel model);
        Task Delete(StockModel model);
        Task Delete(int productId, int storeId);
        Task Update(StockModel model);
        Task<StockModel> Get(int productId, int storeId);
    }
}
