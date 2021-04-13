using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace awwcor_web_api.Repositories
{
    public interface IRepository<T>
    {
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        T GetOne(int? id);
        List<T> GetAll(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null);
    }
}
