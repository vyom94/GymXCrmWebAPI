using CRM.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.EntitiesMapping
{
    public class UsersMap : IEntityTypeConfiguration<Users>
    {
        public virtual void Configure(EntityTypeBuilder<Users> builder)
        { 

            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(25);
            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime2");
            builder.Property(e => e.UpdatedBy).HasMaxLength(25);
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime2");
            builder.Property(e => e.Active).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Deleted).IsRequired().HasColumnType("bit");
            //builder.Property(e => e.ID).IsRequired().HasColumnType("smallint");
            builder.Property(e => e.Email).HasMaxLength(250);
            builder.Property(e => e.FirstName).HasMaxLength(50);
            builder.Property(e => e.LastName).HasMaxLength(150);
            builder.Property(e => e.UserName).HasMaxLength(250);
            //builder.HasOne(a => a.).WithMany(a => a.Apparatus).HasForeignKey(a => a.ApparatusTypeId).WillCascadeOnDelete(false);

            //builder.HasOne(d => d.CreatedByUser)
            // .WithMany(p => p.CreatedOrganizations)
            // .HasForeignKey(d => d.CreatedBy)
            // .HasConstraintName("FK_Organization_CreatedByUser")
            // .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(d => d.UpdatedByUser)
            //   .WithMany(d => d.UpdatedOrganizations)
            //   .HasForeignKey(d => d.UpdatedBy)
            //   .HasConstraintName("FK_Organization_UpdatedUser")
            //   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
