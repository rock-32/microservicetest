using microservicetest.DbContextinherited;
using microservicetest.Model;
using Microsoft.EntityFrameworkCore;

namespace microservicetest.Services
{
    public class StudentService:IStudentService
    {
        private readonly StudentDb _studentDb;
        public StudentService(StudentDb studentDb)
        {
            _studentDb=studentDb;
        }


        public async Task<List<Student>> ListAllStudents()
        {
            return await _studentDb.StudentTb.ToListAsync();
        }
    }
}
