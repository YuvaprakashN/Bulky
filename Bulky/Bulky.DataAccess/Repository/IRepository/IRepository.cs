using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate=null,String? IncludeProperties =null);
        T Get(Expression<Func<T, bool>> predicate,string? IncludeProperties=null, bool tracked = false);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Add(T entity);

    }
}
