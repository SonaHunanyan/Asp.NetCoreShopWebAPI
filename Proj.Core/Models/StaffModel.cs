using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Core.Models
{
   public class StaffModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Acvtive { get; set; }
        public int StoreId { get; set; }
        public int PositionId { get; set; }
    }
}
