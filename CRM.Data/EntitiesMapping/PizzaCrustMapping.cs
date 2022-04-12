using CRM.Models.Enums;
using CRM.Models.RelationModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.EntitiesMapping
{
    public class PizzaCrustMapping : IEntityTypeConfiguration<PizzaCrust>
    {
        public void Configure(EntityTypeBuilder<PizzaCrust> builder)
        {
            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(25);
            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime2");
            builder.Property(e => e.UpdatedBy).HasMaxLength(25);
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime2");
            builder.Property(e => e.Active).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Deleted).IsRequired().HasColumnType("bit");

            builder.HasOne(d => d.PizzaMasterMenu)
                      .WithMany(p => p.PizzaCrust)
                      .HasForeignKey(d => d.PizzaId)
                      .HasConstraintName("FK_PizzaCrust_Master")
                      .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                   new PizzaCrust
                   { Id = 1, PizzaId = 1, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, CrustType = (int)crustEnum.CheeseBurst },
                      new PizzaCrust
                      { Id = 2, PizzaId = 2, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, CrustType = (int)crustEnum.ClassicHandTossed },
                         new PizzaCrust
                         { Id = 3, PizzaId = 3, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, CrustType = (int)crustEnum.FreshPanPizza },
                            new PizzaCrust
                            { Id = 4, PizzaId = 4, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, CrustType = (int)crustEnum.WheatThinCrust }
                );
        }
    }
}
