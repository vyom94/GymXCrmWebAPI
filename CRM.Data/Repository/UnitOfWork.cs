using CRM.Framework.DataContext;
using CRM.Framework.Repositories;
using CRM.Framework.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDataContext _dataContext;
        private AppDbContext _dbContext;
        private bool _disposed;
        private Dictionary<string, dynamic> _repositories;


        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
              _dataContext = dbContext;
            _repositories = new Dictionary<string, dynamic>();
        }

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }
        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class, IObjectState
        {
            if (_repositories == null)
                _repositories = new Dictionary<string, dynamic>();

            var type = typeof(TEntity).Name;

            if (_repositories.ContainsKey(type))
            {
                return (IGenericRepository<TEntity>)_repositories[type];
            }

            var repositoryType = typeof(GenericRepository<>);
            _repositories.Add(type, Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), this));

            return _repositories[type];
        }
        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_dataContext != null)
                    {
                        _dbContext = ((AppDbContext)_dataContext);

                        

                        _dataContext.Dispose();
                        _dataContext = null;
                    }

                    if (_repositories != null)
                        _repositories = null;
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public IDataContext Context
        {
            get { return _dataContext; }
        }
    }
}
