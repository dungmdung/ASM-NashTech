using Assignment10_EFcore.DTOs;
using Assignment10_EFcore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment10_EFcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IEnumerable<GetStudentResponse> GetAll()
        {
            return _studentService.GetAll();
        }

        [HttpGet("GetAstudent/{id}")]
        public GetStudentResponse? GetById(int id)
        {
            return _studentService.GetById(id);
        }

        [HttpPost("NewStudent")]
        public AddStudentResponse? Add([FromBody] AddStudentRequest requestModel)
        {
            return _studentService.Create(requestModel);
        }

        [HttpPut("EditStudent/{id}")]
        public UpdateStudentResponse? Update(int id, [FromBody] UpdateStudentRequest requestModel)
        {
            return _studentService.Update(id, requestModel);
        }

        [HttpDelete("Remove/{id}")]
        public bool Delete(int id)
        {
            return _studentService.Delete(id);
        }
    }
}