using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Core.BllInterfaces
{
    public interface ICustomerOperations
    {
        Task Add(CustomerModel model);
        Task Delete(CustomerModel model);
        Task Delete(int id);
        Task Update(CustomerModel model);
        Task<CustomerModel> Get(int id);
    }
}
