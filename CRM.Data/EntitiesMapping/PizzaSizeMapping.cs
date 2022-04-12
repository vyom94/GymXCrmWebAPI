using CRM.Models.RelationModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using CRM.Models.Enums;

namespace CRM.Data.EntitiesMapping
{
    public class PizzaSizeMapping : IEntityTypeConfiguration<PizzaSize>
    {
        public void Configure(EntityTypeBuilder<PizzaSize> builder)
        {
            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(25);
            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime2");
            builder.Property(e => e.UpdatedBy).HasMaxLength(25);
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime2");
            builder.Property(e => e.Active).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Deleted).IsRequired().HasColumnType("bit");

            builder.HasOne(d => d.PizzaMasterMenu)
                      .WithMany(p => p.PizzaSize)
                      .HasForeignKey(d => d.PizzaId)
                      .HasConstraintName("FK_PizzaSize_Master")
                      .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
            new PizzaSize
            {
                Id = 10,
                PizzaId = 1,
                Active = true,
                Deleted = false,
                CreatedBy = 1,
                CreatedAt = DateTime.UtcNow,
                SizeType = (int)sizeEnum.Large
            },
            new PizzaSize
            {
                Id = 11,
                PizzaId = 1,
                Active = true,
                Deleted = false,
                CreatedBy = 1,
                CreatedAt = DateTime.UtcNow,
                SizeType = (int)sizeEnum.Medium
            },
            new PizzaSize
            { Id = 1, PizzaId = 2, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, SizeType = (int)sizeEnum.Large },
              new PizzaSize
              { Id = 2, PizzaId = 2, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, SizeType = (int)sizeEnum.Medium },
                new PizzaSize
                { Id = 3, PizzaId = 2, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, SizeType = (int)sizeEnum.Regular },
               new PizzaSize
               { Id = 4, PizzaId = 3, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, SizeType = (int)sizeEnum.Large },
               new PizzaSize
               { Id = 5, PizzaId = 3, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, SizeType = (int)sizeEnum.Medium },
                new PizzaSize
                { Id = 6, PizzaId = 3, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, SizeType = (int)sizeEnum.Regular },

               new PizzaSize
               { Id = 7, PizzaId = 4, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, SizeType = (int)sizeEnum.Large },
               new PizzaSize
               { Id = 8, PizzaId = 4, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, SizeType = (int)sizeEnum.Medium },
                new PizzaSize
                { Id = 9, PizzaId = 4, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, SizeType = (int)sizeEnum.Regular });
        }
    }
}
