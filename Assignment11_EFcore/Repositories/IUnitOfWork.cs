using Assignment11_EFcore.Data.Entities;
using Assignment11_EFcore.Repositories;

namespace Assignment11_EFcore.Repositories;

public interface IUnitOfWork
{
    BaseRepository<T> GetRepository<T>() where T : BaseEntity<int>;
    int SaveChanges();
    IDatabaseTransaction GetDatabaseTransaction();
}