using Assignment11_EFcore.Models;

namespace Assignment11_EFcore.Repositories;

public interface IUnitOfWork
{
    BaseRepository<T> GetRepository<T>() where T : BaseEntity<int>;
    int SaveChanges();
    IDatabaseTransaction GetDatabaseTransaction();
}