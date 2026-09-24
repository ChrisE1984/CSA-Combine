using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_Thirteen_API_DB.Models;

namespace Day_Thirteen_API_DB.Services
{
    public interface IStudentServices
    {
        //Only 2 methods
        // a method that gets all students and a method that creates a student
        List<Student> GetAll();

        Student AddStudent (Student newstudent);//paramaters are just placeholders for incoming information
    }
}