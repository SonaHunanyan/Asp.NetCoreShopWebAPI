using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proj.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Dal.Configs
{
    public class StoreConfig : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
           
        }
    }
}
