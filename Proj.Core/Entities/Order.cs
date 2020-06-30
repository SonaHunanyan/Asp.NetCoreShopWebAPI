using System;
using System.Collections.Generic;
using System.Text;
using EntityRepositoriesByNetCycle.EntityAbstractions;

namespace Proj.Core.Entities
{
  public  class Order:EntityBaseWithId
    {
        public int CustomerId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get;set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int StoreId { get; set; }
        public int StaffId { get; set; }
        public Customer Customer { get; set; }
        public Staff Staff { get; set; }
        public Store Store { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

    }
}
