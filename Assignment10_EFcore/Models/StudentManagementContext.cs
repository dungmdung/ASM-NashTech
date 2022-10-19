using Microsoft.EntityFrameworkCore;

namespace Assignment10_EFcore.Models
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
        : base(options)
        {
        }

        public DbSet<Student>? Students { get; set; }
    }
}