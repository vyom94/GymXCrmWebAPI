using CRM.Models.RelationModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.EntitiesMapping
{
    public class PizzaPriceMapping : IEntityTypeConfiguration<PizzaPrice>
    {
        public void Configure(EntityTypeBuilder<PizzaPrice> builder)
        {
            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(25);
            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime2");
            builder.Property(e => e.UpdatedBy).HasMaxLength(25);
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime2");
            builder.Property(e => e.Active).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Deleted).IsRequired().HasColumnType("bit");

            builder.HasOne(d => d.PizzaMasterMenu)
                      .WithMany(p => p.PizzaPrice)
                      .HasForeignKey(d => d.PizzaId)
                      .HasConstraintName("FK_PizzaPrice_Master")
                      .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
        new PizzaPrice
        {
            Id = 1,
            PizzaId = 1,
            Active = true,
            Deleted = false,
            CreatedBy = 1,
            CreatedAt = DateTime.UtcNow,
            Price = 10
        },
         new PizzaPrice
         {
             Id = 2,
             PizzaId = 2,
             Active = true,
             Deleted = false,
             CreatedBy = 1,
             CreatedAt = DateTime.UtcNow,
             Price = 12
         },
          new PizzaPrice
          {
              Id = 3,
              PizzaId = 3,
              Active = true,
              Deleted = false,
              CreatedBy = 1,
              CreatedAt = DateTime.UtcNow,
              Price = 15
          },
           new PizzaPrice
           {
               Id = 4,
               PizzaId = 4,
               Active = true,
               Deleted = false,
               CreatedBy = 1,
               CreatedAt = DateTime.UtcNow,
               Price = 17
           });
        }
    }
}
