using Assignment10_EFcore.Models;
using Assignment10_EFcore.Repositories;

namespace Assignment10_EFcore.SaveChange
{
    public class SaveChange : ISaveChange
    {
        private readonly StudentManagementContext _context;

        public SaveChange(StudentManagementContext context)
        {
            _context = context;
        }

        public BaseRepository<T> GetRepository<T>() where T : BaseEntity<int>
        {
            return new BaseRepository<T>(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}