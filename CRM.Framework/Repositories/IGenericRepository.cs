using CRM.Framework.DataContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CRM.Framework.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class, IObjectState
    {
        IQueryable<TEntity> Queryable();
        IQueryableEntity<TEntity> Query();
        IQueryableEntity<TEntity> Query(Expression<Func<TEntity, bool>> predicate);
        IQueryableEntity<TEntity> Query(IQueryObject<TEntity> queryObject);
        IQueryable<TEntity> SelectQuery(string query, params object[] parameters);
        IQueryable<T> RawQuery<T>(string query, params object[] parameters);
        DataTable ExecuteSQLProc(string procName, params object[] parameters);
        DataSet ExecuteDataSet(string procName, params object[] parameters);
        int ExecuteCommand(string query, params object[] parameters);
        TEntity Find(params object[] keyvalues);
        TEntity Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void InsertBulk(IEnumerable<TEntity> entities);
        void InsertGraphRange(IEnumerable<TEntity> entities);
        void InsertOrUpdateGraph(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(object id);
        void DeleteRange(Expression<Func<TEntity, bool>> predicate);
        IGenericRepository<T> GetRepository<T>() where T : class, IObjectState;
    }
}
