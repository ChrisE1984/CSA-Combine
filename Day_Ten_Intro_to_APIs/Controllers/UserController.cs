
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
//using statements allows a file access to certain classes and methods

//container of our file
namespace Day_Ten_Intro_to_APIs.Controllers
{
    //ApiController allows certain https methods to be passed to our Routes and Methods
    [ApiController]

    //this is our Base Route ex. localhost:5001/api/controller
    [Route("api/[controller]")]
    public class UserController : ControllerBase//ControllerBase gives us Ok(); NotFound();
    {


        string[] studentNames = ["Cal", "Zionn", "Chris", "Zack", "Valerie", "Brandon"];
        //api/user - will call below if entered after url
        [HttpGet]
        public string GetUser()
        {
            return "Isaiah";// displays for /api/user
        }

        [HttpGet]
        [Route("getnamelength")]
        public int GetNameLength()
        {
            return "Isaiah".Length;
        }

        [HttpGet]
        [Route("userinfo")]
        public object GetUserInformation()
        {
            //we are going to return an anonymous object to the browser
            //objects hold key value pairs
            return new
            {
                Name = "Isaiah",
                Job = "Code advocate",
                Hobby = "Martial Arts",
                Age = 36,
            };

        }
        [HttpGet]
        [Route("getallstudents")]
        public string[] GetAllStudents()
        {
            return studentNames;
        }

        [HttpGet]
        [Route("GetStudentByID/{id}")]
            public string GetStudentByID(int id)
        {
            return studentNames [id];
        }

        [HttpGet]
        [Route("addfnln/{firstname}/{lastname}")]// for inputs need to have input parameter(addfnln/{input})
        public string AddFnLn(string firstname, string lastname)
        {
            return $"Welcome to your first API lecture {firstname} {lastname}!";
        }
}
}
