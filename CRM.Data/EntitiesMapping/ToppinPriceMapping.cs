using CRM.Models.Enums;
using CRM.Models.RelationModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.EntitiesMapping
{
    public class ToppinPriceMapping : IEntityTypeConfiguration<ToppingsPrice>
    {
        public void Configure(EntityTypeBuilder<ToppingsPrice> builder)
        {
            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(25);
            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime2");
            builder.Property(e => e.UpdatedBy).HasMaxLength(25);
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime2");
            builder.Property(e => e.Active).IsRequired().HasColumnType("bit");
            builder.Property(e => e.Deleted).IsRequired().HasColumnType("bit");
            builder.Property(e => e.ToppingType).IsRequired();
            builder.Property(e => e.Price).IsRequired();



            builder.HasData(
        new ToppingsPrice
        {
            Id = 1,
            ToppingType = (int)toppingEnums.ChickenSausage,
            Active = true,
            Deleted = false,
            CreatedBy = 1,
            CreatedAt = DateTime.UtcNow,
            Price = 10
        },
           new ToppingsPrice
           {
               Id = 2,
               ToppingType = (int)toppingEnums.ChickenTikka,
               Active = true,
               Deleted = false,
               CreatedBy = 1,
               CreatedAt = DateTime.UtcNow,
               Price = 5
           },
              new ToppingsPrice
              {
                  Id = 3,
                  ToppingType = (int)toppingEnums.ChillyPaneer,
                  Active = true,
                  Deleted = false,
                  CreatedBy = 1,
                  CreatedAt = DateTime.UtcNow,
                  Price = 4
              },
                 new ToppingsPrice
                 {
                     Id = 4,
                     ToppingType = (int)toppingEnums.FreshTomato,
                     Active = true,
                     Deleted = false,
                     CreatedBy = 1,
                     CreatedAt = DateTime.UtcNow,
                     Price = 2
                 },
                    new ToppingsPrice
                    {
                        Id = 5,
                        ToppingType = (int)toppingEnums.ChickenSausage,
                        Active = true,
                        Deleted = false,
                        CreatedBy = 1,
                        CreatedAt = DateTime.UtcNow,
                        Price = 4
                    },
                       new ToppingsPrice
                       {
                           Id = 6,
                           ToppingType = (int)toppingEnums.GrilledChickenRasher,
                           Active = true,
                           Deleted = false,
                           CreatedBy = 1,
                           CreatedAt = DateTime.UtcNow,
                           Price = 3
                       },
                          new ToppingsPrice
                          {
                              Id = 7,
                              ToppingType = (int)toppingEnums.GrilledMushrooms,
                              Active = true,
                              Deleted = false,
                              CreatedBy = 1,
                              CreatedAt = DateTime.UtcNow,
                              Price = 1
                          },
                            new ToppingsPrice
                            {
                                Id = 8,
                                ToppingType = (int)toppingEnums.Onion,
                                Active = true,
                                Deleted = false,
                                CreatedBy = 1,
                                CreatedAt = DateTime.UtcNow,
                                Price = 2
                            });
        }
    }
}
