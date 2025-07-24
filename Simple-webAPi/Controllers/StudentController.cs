using Microsoft.AspNetCore.Mvc;
using Simple_webAPi.Interface;
using Simple_webAPi.Models;

namespace Simple_webAPi.Controllers
{
    [Route("StudentController")]
    [ApiController]
    public class StudentController : Controller
    {
        private IStudent _studentService;

        public StudentController(IStudent studentService)
        {
            _studentService = studentService;
        }


        [HttpPost("SaveStudent")]
        public IActionResult SaveStudent(Student std)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            var res = _studentService.SaveStudent(std);
            return Ok(res);
        }



        [HttpPut("updateStudent")]
        public IActionResult UpdateStudent(Student std)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            var res = _studentService.UpdateStudent(std);
            return Ok(res);
        }

        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            var res = _studentService.GetAllStudents();
            return Ok(res);
        }

        [HttpGet("GetStudentByEmail")]
        public IActionResult GetStudentByEmail(string email)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            var res = _studentService.GetStudentByEmail(email);
            return Ok(res);
        }

        [HttpDelete("DeleteStudentByEmail")]
        public IActionResult DeleteStudent(string email)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            var res = _studentService.DeleteStudent(email);
            return Ok(res);
        }
    }
}
