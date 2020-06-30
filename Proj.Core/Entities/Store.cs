using System;
using System.Collections.Generic;
using System.Text;
using EntityRepositoriesByNetCycle.EntityAbstractions;
namespace Proj.Core.Entities
{
   public class Store:EntityBaseWithId
    {
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public List<Staff> Staffs { get; set; }
        public List<Order> Orders { get; set; }
        public List<Stock> Stocks { get; set; }

    }
}
