using microservicetest.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace microservicetest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService) 
        { 
            _studentService = studentService;
        }

        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _studentService.ListAllStudents());
        }

        
    }
}
