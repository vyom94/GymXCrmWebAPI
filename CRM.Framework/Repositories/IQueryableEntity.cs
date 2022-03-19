using CRM.Framework.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CRM.Framework.Repositories
{
    public interface IQueryableEntity<TEntity> where TEntity : class, IObjectState
    {
        IQueryableEntity<TEntity> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
        //IQueryableEntity<TEntity> OrderBy(string sortBy, bool reverse = false);
        IQueryableEntity<TEntity> Include(Expression<Func<TEntity, object>> expression);
        IEnumerable<TEntity> SelectPage(int page, int pageSize, out int totalCount, bool trackable = false);
        IEnumerable<TResult> Select<TResult>(Expression<Func<TEntity, TResult>> selector = null, bool trackable = false);
        IEnumerable<TEntity> Select(bool trackable = false);
        IQueryable<TEntity> SqlQuery(string query, params object[] parameters);
    }
}
