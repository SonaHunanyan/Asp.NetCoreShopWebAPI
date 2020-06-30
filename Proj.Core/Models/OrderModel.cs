using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Core.Models
{
   public class OrderModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int StoreId { get; set; }
        public int StaffId { get; set; }
    }
}
