using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
  public  interface IProductOperations
    {
        Task Add(ProductModel model);
        Task Delete(ProductModel model);
        Task Delete(int id);
        Task Update(ProductModel model);
        Task<ProductModel> Get(int id);
    }
}
