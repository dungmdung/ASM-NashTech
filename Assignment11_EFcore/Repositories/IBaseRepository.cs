using System.Linq.Expressions;
using Assignment11_EFcore.Models;

namespace Assignment11_EFcore.Repositories;

public interface IBaseRepository<T> where T : BaseEntity<int>
{
    IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate = null);
    T? Get(Expression<Func<T, bool>>? predicate = null);
    T Create(T entity);
    T Update(T entity);
    void Delete(T entity);
}