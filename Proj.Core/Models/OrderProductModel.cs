using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Core.Models
{
  public  class OrderProductModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int ListPrice { get; set; }
        public int Discount { get; set; }
    }
}
