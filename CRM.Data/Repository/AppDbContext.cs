using CRM.Data.Extensions;
using CRM.Framework.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CRM.Data.Repository
{
    public class AppDbContext : DbContext, IDataContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.ApplyAllConfigurations();
 //           var mapLists = Assembly.GetExecutingAssembly().GetTypes()
 //.Where(type => !string.IsNullOrWhiteSpace(type.Namespace)
 //    && typeof(IEntityTypeConfiguration<>).IsAssignableFrom(type)
 //    && type.IsGenericType == false
 //    && type.IsClass).ToList();

 //           foreach (var item in mapLists)
 //           {
 //               Activator.CreateInstance(item, BindingFlags.Public |
 //               BindingFlags.Instance, null, new object[] { builder }, null);
 //           }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        private void SyncObjectsStatePreCommit()
        {
            foreach (var dbEntityEntry in ChangeTracker.Entries())
            {
                dbEntityEntry.State = EntityStateHelper.ConvertState(((IObjectState)dbEntityEntry.Entity).ObjectState);
            }
        }

        public void SyncObjectStatePostCommit()
        {
            foreach (var dbEntityEntry in ChangeTracker.Entries())
            {
                ((IObjectState)dbEntityEntry.Entity).ObjectState = EntityStateHelper.ConvertState(dbEntityEntry.State);
                dbEntityEntry.State = EntityState.Detached;
            }
        }


        public override int SaveChanges()
        {
            SyncObjectsStatePreCommit();
            var changes = base.SaveChanges();
            SyncObjectStatePostCommit();
            return changes;
        }

        void IDataContext.SyncObjectState<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
