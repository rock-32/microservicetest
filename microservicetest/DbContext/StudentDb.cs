using microservicetest.Model;
using Microsoft.EntityFrameworkCore;

namespace microservicetest.DbContextinherited
{
    public class StudentDb:DbContext
    {
        public StudentDb(DbContextOptions<StudentDb> option) : base(option)
        {

        }
        public DbSet<Student> StudentTb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
