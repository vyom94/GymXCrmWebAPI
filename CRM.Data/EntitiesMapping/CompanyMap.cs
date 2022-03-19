using CRM.Models.SysConfig;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRM.Data.EntitiesMapping
{
    public class CompanyMap : BaseMasterEntityConfiguration<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);
            //builder.Property(e => e.ID).IsRequired().HasColumnType("smallint");
            builder.Property(e => e.Address).HasMaxLength(250);
            builder.Property(e => e.CompanyName).HasMaxLength(50);
            builder.Property(e => e.Contact).HasMaxLength(150);
            builder.Property(e => e.CompanyLogo).HasMaxLength(250);
            builder.Property(e => e.Email).HasMaxLength(250);

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

            //builder.HasData(
            //    new { ID = (long)1, OrganizationID = (long)1, Name = "Enerex Energy", ExternalID = Guid.Parse("0152AE31-A71A-4C0C-993C-CA1EBC5C66AB"), XChangeID = Guid.Parse("0152AE31-A71A-4C0C-993C-CA1EBC5C66AB"), SearchTerm = "enerexenergy", TimeZone = "Eastern Standard Time", DBAName = "Enerex Energy", CreatedBy = (long)1, CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc), Active = true, Deleted = false },
            //    new { ID = (long)2, OrganizationID = (long)2, Name = "Marathon Energy", ExternalID = Guid.Parse("749454D9-06CA-4EDE-B8D1-384CB5694883"), XChangeID = Guid.Parse("CF6F539A-4271-4741-839F-BC786DD6003C"), SearchTerm = "marathonenergy", TimeZone = "Eastern Standard Time", DBAName = "Marathon Energy", CreatedBy = (long)1, CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc), Active = true, Deleted = false }
            //);
        }
    }
}
