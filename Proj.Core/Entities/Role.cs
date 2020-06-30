using System;
using System.Collections.Generic;
using System.Text;
using EntityRepositoriesByNetCycle.EntityAbstractions;
namespace Proj.Core.Entities
{
   public class Role: EntityBaseWithId
    {
        public string RoleName { get; set; }
        public List<User> Users { get; set; }
    }
}
