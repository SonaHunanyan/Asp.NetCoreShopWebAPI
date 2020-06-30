using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
  public  interface IStoreOperations
    {
        Task Add(StoreModel model);
        Task Delete(StoreModel model);
        Task Delete(int storeId);
        Task Update(StoreModel model);
        Task<StoreModel> Get(int id);
    }
}
