using System;
using System.Collections.Generic;
using System.Text;
using EntityRepositoriesByNetCycle.EntityAbstractions;
namespace Proj.Core.Entities
{
   public class Position:EntityBaseWithId
    {
        public string PositionName { get; set; }
        public List<Staff> Staffs { get; set; }
    }
}
