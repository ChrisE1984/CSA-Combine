using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_Thirteen_API_DB.Models;
using Day_Thirteen_API_DB.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day_Thirteen_API_DB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _student;
        public StudentController(IStudentServices student)
        {
            _student = student;// supplying the empty variable with methods from our student services
        }

        [HttpGet("getallstudents")]
        public ActionResult <List<Student>> GetAll()
        {
            List<Student> students = _student.GetAll();

            return Ok(students);
        }

        [HttpPost("Create")]

        public ActionResult<Student> Create ([FromBody] Student newStudent)
        {
            Student createdStudent = _student.AddStudent(newStudent);
            return CreatedAtAction(
                nameof(GetAll),
                createdStudent 
            );
        }
    }
}