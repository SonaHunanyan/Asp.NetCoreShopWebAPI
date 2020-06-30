using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Core.Models
{
   public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public int RoleId { get; set; }
    }
}
