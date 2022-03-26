using CRM.Models.RelationModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.EntitiesMapping
{
    class CompanyUsersMap : IEntityTypeConfiguration<CompanyUsers>
    {
        public void Configure(EntityTypeBuilder<CompanyUsers> builder)
        {
            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(25);
            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime2");
            builder.Property(e => e.UpdatedBy).HasMaxLength(25);
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime2");
            builder.Property(e => e.Active).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Deleted).IsRequired().HasColumnType("bit");

            builder.HasOne(d => d.Company)
                      .WithMany(p => p.CompanyUsers)
                      .HasForeignKey(d => d.CompanyID)
                      .HasConstraintName("FK_CompanyUser_Company")
                      .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(d => d.Users)
                .WithMany(p => p.CompanyUsers)
                .HasForeignKey(d => d.UserID)
                .HasConstraintName("FK_CompanyUser_User")
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
