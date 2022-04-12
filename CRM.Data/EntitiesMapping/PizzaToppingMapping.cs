using CRM.Models.Enums;
using CRM.Models.RelationModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.EntitiesMapping
{
    public class PizzaToppingMapping : IEntityTypeConfiguration<PizzaToppings>
    {
        public void Configure(EntityTypeBuilder<PizzaToppings> builder)
        {
            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(25);
            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime2");
            builder.Property(e => e.UpdatedBy).HasMaxLength(25);
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime2");
            builder.Property(e => e.Active).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Deleted).IsRequired().HasColumnType("bit");

            builder.HasOne(d => d.PizzaMasterMenu)
                      .WithMany(p => p.PizzaToppings)
                      .HasForeignKey(d => d.PizzaId)
                      .HasConstraintName("FK_PizzaToppings_Master")
                      .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
                  new PizzaToppings
                  { Id = 1, PizzaId = 1, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.ChickenTikka },
                    new PizzaToppings
                    { Id = 2, PizzaId = 1, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.FreshTomato },
                      new PizzaToppings
                      { Id = 3, PizzaId = 1, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.Onion },

                        new PizzaToppings
                        { Id = 4, PizzaId = 2, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.FreshTomato },
                    new PizzaToppings
                    { Id = 5, PizzaId = 2, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.GrilledMushrooms },
                      new PizzaToppings
                      { Id = 6, PizzaId = 2, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.Onion },

                        new PizzaToppings
                        { Id = 7, PizzaId = 3, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.GrilledChickenRasher },
                    new PizzaToppings
                    { Id = 8, PizzaId = 3, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.FreshTomato },
                      new PizzaToppings
                      { Id = 9, PizzaId = 3, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.Onion },

                        new PizzaToppings
                        { Id = 10, PizzaId = 4, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.ChillyPaneer },
                    new PizzaToppings
                    { Id = 11, PizzaId = 4, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.FreshTomato },
                      new PizzaToppings
                      { Id = 12, PizzaId = 4, Active = true, Deleted = false, CreatedBy = 1, CreatedAt = DateTime.UtcNow, ToppingType = (int)toppingEnums.GrilledMushrooms }


                );
        }
    }
}
