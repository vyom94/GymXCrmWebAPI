using CRM.Models.PizzaMenu;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.EntitiesMapping
{
    public class PizzaMenuMapping : IEntityTypeConfiguration<PizzaMasterMenu>
    {
        public virtual void Configure(EntityTypeBuilder<PizzaMasterMenu> builder)
        {

            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(25);
            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime2");
            builder.Property(e => e.UpdatedBy).HasMaxLength(25);
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime2");
            builder.Property(e => e.Active).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Deleted).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Name).HasMaxLength(250);

            builder.HasData
   (
       new PizzaMasterMenu
       {
           Id = 1,
           Name = "Chicken Tikka Pizza",
           Active = true,
           Deleted=false,
           CreatedBy=1,
           CreatedAt = DateTime.UtcNow
       },
         new PizzaMasterMenu
         {
             Id = 2,
             Name = "Veg Exotic Pizza",
             Active = true,
             Deleted = false,
             CreatedBy = 1,
             CreatedAt=DateTime.UtcNow
         },
         new PizzaMasterMenu
         {
             Id = 3,
             Name = "Chilly Chicken Pizza",
             Active = true,
             Deleted = false,
             CreatedBy = 1,
             CreatedAt = DateTime.UtcNow
         },
         new PizzaMasterMenu
         {
             Id = 4,
             Name = "Chilly Paneer Pizza",
             Active = true,
             Deleted = false,
             CreatedBy = 1,
             CreatedAt = DateTime.UtcNow
         }

   ); 
        }
    }
}
