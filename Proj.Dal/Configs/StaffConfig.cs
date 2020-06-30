using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proj.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Dal.Configs
{
    public class StaffConfig : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasOne(x => x.Store)
                .WithMany(x => x.Staffs)
                .HasForeignKey(x => x.StoreId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Position)
                .WithMany(x => x.Staffs)
                .HasForeignKey(x => x.PositionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
