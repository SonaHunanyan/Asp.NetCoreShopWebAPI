using System;
using System.Collections.Generic;
using System.Text;
using EntityRepositoriesByNetCycle.EntityAbstractions;

namespace Proj.Core.Entities
{
   public class Stock:IEntityBase
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Store Store { get; set; }
        public Product Product { get; set; }

    }
}
