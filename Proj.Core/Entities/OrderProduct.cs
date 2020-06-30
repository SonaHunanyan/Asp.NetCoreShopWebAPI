using System;
using System.Collections.Generic;
using System.Text;
using EntityRepositoriesByNetCycle.EntityAbstractions;

namespace Proj.Core.Entities
{
   public class OrderProduct:IEntityBase
    { 
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int ListPrice { get; set; }
        public int Discount { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
