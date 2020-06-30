using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
   public interface IPositionOperations
    {
        Task Add(PositionModel model);
        Task Delete(PositionModel model);
        Task Delete(int id);
        Task Update(PositionModel model);
        Task<PositionModel> Get(int id);
    }
}
