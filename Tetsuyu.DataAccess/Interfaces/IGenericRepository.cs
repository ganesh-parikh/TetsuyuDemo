using System;
using System.Collections.Generic;
using System.Text;
using Tetsuyu.EntitiesCore.Models;

namespace Tetsuyu.DataAccess.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByPredicate(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        void RemoveAllByPredicate(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void EditOptional(T entity, T updatedEntity, List<string> properties = null);
        T FindById(object id);
        void RemoveById(object id);
        void RemoveByPredicate(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        void RemoveRange(IEnumerable<T> entities);
        void Edit(T entity, Func<T, T> findByPrimaryKey = null);
        void Commit();

        void TrimSpaces(ref T entity, List<string> excludeproperties);
        CoreDbContext Context
        {
            get;
            set;
        }
    }
}
