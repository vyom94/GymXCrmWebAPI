using CRM.Framework.DataContext;
using CRM.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Linq.Dynamic;

namespace CRM.Data.Repository
{
    public class QueryableEntity<TEntity> : IQueryableEntity<TEntity> where TEntity : class, IObjectState
    {

        #region Private Fields
        private readonly Expression<Func<TEntity, bool>> _expression;
        private readonly List<Expression<Func<TEntity, object>>> _includes;
        private readonly GenericRepository<TEntity> _repository;
        private Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> _orderBy;
        private string _sortByProperty;
        private string _sortInReverse;
        #endregion Private Fields

        #region Constructors
        public QueryableEntity(GenericRepository<TEntity> repository)
        {
            _repository = repository;
            _includes = new List<Expression<Func<TEntity, object>>>();
        }

        public QueryableEntity(GenericRepository<TEntity> repository, IQueryObject<TEntity> queryObject)
            : this(repository)
        {
            _expression = queryObject.Query();
        }

        public QueryableEntity(GenericRepository<TEntity> repository, Expression<Func<TEntity, bool>> expression)
            : this(repository)
        {
            _expression = expression;
        }
        #endregion Constructors


        public IQueryableEntity<TEntity> Include(Expression<Func<TEntity, object>> expression)
        {
            _includes.Add(expression);
            return this;
        }

        public IQueryableEntity<TEntity> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {
            _orderBy = orderBy;
            return this;
        }

        //public IQueryableEntity<TEntity> OrderBy(string sortBy, bool reverse = false)
        //{
        //    _sortByProperty = sortBy;
        //    _sortInReverse = reverse ? " descending" : "";
        //    _orderBy = new Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>(OrderedQuery);
        //    return this;
        //}

        //private IOrderedQueryable<TEntity> OrderedQuery(IQueryable<TEntity> arg)
        //{
        //    return (IOrderedQueryable<TEntity>)arg.OrderBy(_sortByProperty + _sortInReverse);
        //}

        public IEnumerable<TEntity> Select(bool trackable = false)
        {
            return _repository.Select(_expression, _orderBy, _includes, null, null, trackable);
        }

        public IEnumerable<TResult> Select<TResult>(Expression<Func<TEntity, TResult>> selector = null, bool trackable = false)
        {
            return _repository.Select(_expression, _orderBy, _includes, null, null, trackable).Select(selector);
        }

        public IEnumerable<TEntity> SelectPage(int page, int pageSize, out int totalCount, bool trackable = false)
        {
            totalCount = _repository.Select(_expression).Count();
            return _repository.Select(_expression, _orderBy, _includes, page, pageSize, trackable);
        }

        public IQueryable<TEntity> SqlQuery(string query, params object[] parameters)
        {
            return _repository.SelectQuery(query, parameters).AsQueryable();
        }
        public override bool Equals(object obj)
        {
            return obj is QueryableEntity<TEntity> entity &&
                   EqualityComparer<GenericRepository<TEntity>>.Default.Equals(_repository, entity._repository);
        }
    }
}
