using CRM.Framework.DataContext;
using CRM.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Framework.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void BeginTransaction();
        void Commit();
        void Rollback();
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class, IObjectState;
        IDataContext Context { get; }
    }
}
