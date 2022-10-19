using Assignment10_EFcore.Models;

namespace Assignment10_EFcore.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(StudentManagementContext context) : base(context)
        {
        }
    }
}