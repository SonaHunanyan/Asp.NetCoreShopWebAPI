using System;
using System.Collections.Generic;
using EntityRepositoriesByNetCycle.EntityAbstractions;
using Proj.Core.Entities;

namespace Proj.Core
{
    public class Category:EntityBaseWithId
    {
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
