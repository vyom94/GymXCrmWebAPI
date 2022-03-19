using CRM.Framework.DataContext;
using CRM.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CRM.Framework.Services
{
    public interface IService<TEntity> where TEntity : class, IObjectState
    {
        TEntity Find(params object[] keyValues);
        IQueryable<TEntity> SelectQuery(string query, params object[] parameters);
        TEntity Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void InsertGraphRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entity);
        IQueryableEntity<TEntity> Query();
        IQueryableEntity<TEntity> Query(IQueryObject<TEntity> queryObject);
        IQueryableEntity<TEntity> Query(Expression<Func<TEntity, bool>> query);
        IQueryable<TEntity> Queryable();
    }
}
