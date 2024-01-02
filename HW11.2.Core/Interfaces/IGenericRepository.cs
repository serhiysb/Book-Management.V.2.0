using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HW11._2.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddEntity(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> Find(Expression<Func<T, bool>> predicate);
        void DeleteEntity(T entity);
        Task DeleteById(int id);
        void UpdateEntity(T entity);
    }
}
