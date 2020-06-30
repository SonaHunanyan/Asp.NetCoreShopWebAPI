using System;
using System.Collections.Generic;
using System.Text;
using EntityRepositoriesByNetCycle.EntityAbstractions;

namespace Proj.Core.Entities
{
   public class Product:EntityBaseWithId
    {
        public string ProductName { get; set; }
        public int BrnadId { get; set; }
        public int CategoryId { get; set; }
        public int ModelYear { get; set; }
        public int ListPrice { get; set; }
        public Category Category { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
        public List<Stock> Stocks { get; set; }
        public Brand Brand { get; set; }


    }
}
