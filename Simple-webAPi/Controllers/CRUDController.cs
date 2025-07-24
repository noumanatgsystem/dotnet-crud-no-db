using Microsoft.AspNetCore.Mvc;
using Simple_webAPi.Interface;
using Simple_webAPi.Models;

namespace Simple_webAPi.Controllers
{
    [Route("CRUD")]
    [ApiController]
    public class CRUDController : ControllerBase
    {
        public ICRUD _service;

        public CRUDController(ICRUD service)
        {
            _service = service;
        }


        [HttpPost("SaveStudent")]
        public IActionResult SaveStudent(Student std)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Student Data");
            }

            var res = _service.SaveStudent(std);
            return Ok(res);
        }


        [HttpGet("GetAllStudent")]
        public IActionResult GetAllStd()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Request");
            }
            var res = _service.GetAllStudent();
            return Ok(res);
        }


        [HttpGet("GETSTDbyEmail")]

        public IActionResult GetStudentByEmail(string email)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Email cannot be null or empty");
            }
            var res = _service.GetStudentByEmail(email);
            return Ok(res);
        }


        [HttpPut("UpdateStudent")]

        public IActionResult UpdateStudent(Student std)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Student Data");
            }

            var res = _service.UpdateStudent(std);
            return Ok(res);
        }

        [HttpDelete("DeleteStudentByEmail")]

        public IActionResult DeleteStudent(string email)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Email cannot be null or empty");
            }
            var res = _service.DeleteStudent(email);
            return Ok(res);
        }

    }
}
