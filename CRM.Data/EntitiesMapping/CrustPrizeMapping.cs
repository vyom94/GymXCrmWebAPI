using CRM.Models.Enums;
using CRM.Models.RelationModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.EntitiesMapping
{
    public class CrustPrizeMapping : IEntityTypeConfiguration<CrustPrice>
    {
        public void Configure(EntityTypeBuilder<CrustPrice> builder)
        {

            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(25);
            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime2");
            builder.Property(e => e.UpdatedBy).HasMaxLength(25);
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime2");
            builder.Property(e => e.Active).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Deleted).IsRequired().HasColumnType("bit");
            builder.Property(e => e.CrustType).IsRequired();
            builder.Property(e => e.Price).IsRequired();
          
            builder.HasOne(d => d.PizzaCrust)
                   .WithMany(p => p.CrustPrice)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
        new CrustPrice
        {
            Id = 1,
            CrustType = (int)crustEnum.CheeseBurst,
            Active = true,
            Deleted = false,
            CreatedBy = 1,
            CreatedAt = DateTime.UtcNow,
            Price = 10
        }, new CrustPrice
        {
            Id = 2,
            CrustType = (int)crustEnum.ClassicHandTossed,
            Active = true,
            Deleted = false,
            CreatedBy = 1,
            CreatedAt = DateTime.UtcNow,
            Price = 5
        }, new CrustPrice
        {
            Id = 3,
            CrustType = (int)crustEnum.FreshPanPizza,
            Active = true,
            Deleted = false,
            CreatedBy = 1,
            CreatedAt = DateTime.UtcNow,
            Price = 7
        }, new CrustPrice
        {
            Id = 4,
            CrustType = (int)crustEnum.WheatThinCrust,
            Active = true,
            Deleted = false,
            CreatedBy = 1,
            CreatedAt = DateTime.UtcNow,
            Price = 12
        });
        }
    }
}
