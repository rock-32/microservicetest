using Microsoft.EntityFrameworkCore;
using testmicroservice2.Model;

namespace testmicroservice2.DbContextinherited
{
    public class DepartmentDb:DbContext
    {
        public DepartmentDb(DbContextOptions<DepartmentDb> options) :base(options)
        {

        }
        public DbSet<Department> DepartmentTb {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        
    }
}
