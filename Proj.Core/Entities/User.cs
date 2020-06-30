using EntityRepositoriesByNetCycle.EntityAbstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Core.Entities
{
   public class User: EntityBaseWithId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public int RoleId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsBlocked { get; set; }
        public Role Role { get; set; }
    }
}
