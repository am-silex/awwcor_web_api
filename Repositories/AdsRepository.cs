using awwcor_web_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace awwcor_web_api.Repositories
{
    public class AdsRepository<T> : IRepository<T> where T : class, new()
    {
        private readonly DbSet<T> _table;
        protected DatabaseContext _dbContext;
        public AdsRepository(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
            _table = _dbContext.Set<T>();
        }
        public int Add(T entity)
        {
            try 
            {
                _table.Add(entity);
                return _dbContext.SaveChanges();
            }
	        catch (global::System.Exception ex)
	        {
                throw new Exception($"Couldn't add new entity: {ex.Message}");
            }
        }
        public int Update (T entity)
        {
            try
            {
                _table.Update(entity);
                return _dbContext.SaveChanges();
            }
            catch (global::System.Exception ex)
            {
                throw new Exception($"Couldn't update entity: {ex.Message}");
            }
        }
        public int Delete(T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Deleted;
                return _dbContext.SaveChanges();
            }
            catch (global::System.Exception ex)
            {
                throw new Exception($"Couldn't delete entity: {ex.Message}");
            }
        }
        public T GetOne(int? id)
        {
            return _table.Find(id);
        }
        public List<T> GetAll(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null)
        {
            IQueryable<T> query = _table.AsQueryable<T>();
            if (includes != null)
            {     
                foreach (var includeProperty in includes)
                {
                    query.Include(includeProperty);
                }
            }
            return query.AsNoTracking().ToList<T>();
        }

    }
}
