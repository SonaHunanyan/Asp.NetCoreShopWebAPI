using System;
using System.Collections.Generic;
using System.Text;
using EntityRepositoriesByNetCycle.EntityAbstractions;

namespace Proj.Core.Entities
{
    public class Staff:EntityBaseWithId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Acvtive { get; set; }
        public int StoreId { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public Store Store { get; set; }
        public List<Order> Orders { get; set; }

    }
}
