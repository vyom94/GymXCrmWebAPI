using CRM.Framework.DataContext;
using CRM.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Framework.UnitOfWork
{
    public interface IUnitOfWork 
    {
        int SaveChanges();
        IDataContext Context { get; }

        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class, IObjectState;

    }
}
