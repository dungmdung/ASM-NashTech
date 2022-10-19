using System.Linq.Expressions;
using Assignment10_EFcore.Models;

namespace Assignment10_EFcore.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity<int>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
        T? Get(Expression<Func<T, bool>> predicate);
        T Create(T entity);
        T Update(T entity);
        bool Delete(T entity);
    }
}