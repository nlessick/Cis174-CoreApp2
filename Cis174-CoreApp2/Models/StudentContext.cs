using Microsoft.EntityFrameworkCore;

namespace Cis174_CoreApp2.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 1,
                    FirstName = "Nate",
                    LastName = "Essick",
                    Grade = 'B'
                },
                new Student
                {
                    StudentID = 2,
                    FirstName = "Hawkeye",
                    LastName = "Herkey",
                    Grade = 'A'
                },
                new Student
                {
                    StudentID = 3,
                    FirstName = "Indianapolis",
                    LastName = "Colts",
                    Grade = 'B'
                }
                );
        }
    }
}

