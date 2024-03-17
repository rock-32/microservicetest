using testmicroservice2.Model;

namespace testmicroservice2.Services
{
    public interface IDepartmentService
    {
        Task<List<Department>> ListDipartments();
    }
}
