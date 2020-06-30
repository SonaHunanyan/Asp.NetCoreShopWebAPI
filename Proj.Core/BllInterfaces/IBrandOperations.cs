using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core
{
  public  interface IBrandOperations
    {
        Task Add(BrandModel model);

        Task Delete(BrandModel model);
        Task Delete(int id);
        Task Update(BrandModel model);
        Task<BrandModel> Get(int id);
    }
}
