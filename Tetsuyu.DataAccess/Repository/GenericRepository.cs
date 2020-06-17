using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Tetsuyu.DataAccess.Interfaces;
using Tetsuyu.EntitiesCore.Models;

namespace Tetsuyu.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //todo: error handling??      
        private DbContext _context;
        public CoreDbContext Context
        {
            get
            {
                if (_context is CoreDbContext)
                {
                    return (CoreDbContext)_context;
                }
                else
                {
                    return null;
                }
            }
            set { _context = value; }
        }

  

        public GenericRepository(CoreDbContext context)
        {
            _context = context;
        }

       

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        /// <summary>
        /// Edits the entity on the context by first attaching and then
        /// setting it's state to Modified. In a scenario where the same
        /// entity may have been read prior and exist in the context, it
        /// is necessary to provide a function that returns the existing
        /// entity or null if it doesn't exist from the context. 
        /// For an example of this method, see the WriteIncomes method of 
        /// HouseholdApplicationSaveRepoDAO.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="findByPrimaryKey"></param>
        public void Edit(T entity, Func<T, T> findByPrimaryKey = null)
        {
            if (findByPrimaryKey == null)
            {
                _context.Set<T>().Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }
            else
            {
                var found = findByPrimaryKey(entity);

                if (found != null)
                {
                    _context.Entry(found).CurrentValues.SetValues(entity);
                }
                else
                {
                    _context.Set<T>().Attach(entity);
                    _context.Entry(entity).State = EntityState.Modified;
                }
            }
        }


        public void EditOptional(T entity, T updatedEntity, List<string> properties = null)
        {
            _context.Entry(entity).CurrentValues.SetValues(updatedEntity);
            if (properties != null)
            {
                if (properties.Count > 0)
                {
                    foreach (string prop in properties)
                    {
                        _context.Entry(entity).Property(prop).IsModified = false;
                    }
                }
            }

        }

        public T FindById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public IEnumerable<T> GetAllByPredicate(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void RemoveById(object id)
        {
            T entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                Remove(entity);
            }
        }

        public void RemoveByPredicate(Expression<Func<T, bool>> predicate)
        {
            T entity = _context.Set<T>().Where(predicate).FirstOrDefault();
            if (entity != null)
            {
                Remove(entity);
            }
        }

        public void RemoveAllByPredicate(Expression<Func<T, bool>> predicate)
        {
            var entity = _context.Set<T>().Where(predicate);
            if (entity != null)
            {
                RemoveRange(entity);
            }
        }

        public virtual void Commit()
        {
            _context.SaveChanges();
        }

        public virtual void TrimSpaces(ref T entity, List<string> excludeproperties)
        {
            Type EntityType = entity.GetType();
            PropertyInfo[] propertyInfos = EntityType.GetProperties();
            foreach (PropertyInfo info in propertyInfos)
            {
                if (info.PropertyType == typeof(string))
                {
                    if (!excludeproperties.Contains(info.Name))
                    {
                        var value = entity.GetType().GetProperty(info.Name).GetValue(entity, null);
                        if (value != null)
                        {
                            PropertyInfo propertyInfo = entity.GetType().GetProperty(info.Name);
                            propertyInfo.SetValue(entity, value.ToString().TrimStart().TrimEnd(), null);
                        }
                    }
                }
            }
        }
    }
}
