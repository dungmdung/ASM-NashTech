using Assignment10_EFcore.Models;

namespace Assignment10_EFcore.Repositories
{
    public class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository(StudentManagementContext context) : base(context)
        {
        }
    }
}