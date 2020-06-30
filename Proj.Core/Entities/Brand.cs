using System;
using System.Collections.Generic;
using System.Text;
using EntityRepositoriesByNetCycle.EntityAbstractions;
namespace Proj.Core.Entities
{
 public   class Brand:EntityBaseWithId
    {
        public string BrandName { get; set; }
        public List<Product> Products { get; set; }
    }
}
