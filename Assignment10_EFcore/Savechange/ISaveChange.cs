using Assignment10_EFcore.Models;
using Assignment10_EFcore.Repositories;

namespace Assignment10_EFcore.SaveChange
{
    public interface ISaveChange
    {
        BaseRepository<T> GetRepository<T>() where T : BaseEntity<int>;
        int SaveChanges();
    }
}