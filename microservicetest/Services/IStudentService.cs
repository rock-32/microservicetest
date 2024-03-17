using microservicetest.Model;

namespace microservicetest.Services
{
    public interface IStudentService
    {
        Task<List<Student>> ListAllStudents();
    }
}
