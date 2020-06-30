using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
    public interface ICategoryOperations
    {
        Task Add(CategoryModel model);
        Task Delete(CategoryModel model);
        Task Delete(int id);
        Task Update(CategoryModel model);
        Task<CategoryModel> Get(int id);
    }
}
