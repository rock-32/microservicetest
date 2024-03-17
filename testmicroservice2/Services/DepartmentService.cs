using Microsoft.EntityFrameworkCore;
using testmicroservice2.DbContextinherited;
using testmicroservice2.Model;

namespace testmicroservice2.Services
{
    public class DepartmentService: IDepartmentService
    {
        private readonly DepartmentDb _departmentDb;
        public DepartmentService(DepartmentDb departmentDb)
        {
            _departmentDb = departmentDb;
        }

        public async Task<List<Department>> ListDipartments()
        {
            return await _departmentDb.DepartmentTb.ToListAsync();
        }
    }
}
