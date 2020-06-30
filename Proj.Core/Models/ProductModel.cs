using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Core.Models
{
   public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int BrnadId { get; set; }
        public int CategoryId { get; set; }
        public int ModelYear { get; set; }
        public int ListPrice { get; set; }
    }
}
