using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Day_Thirteen_API_DB.Data;
using Day_Thirteen_API_DB.Models;

namespace Day_Thirteen_API_DB.Services
{
    public class StudentServices : IStudentServices
    {
        private AppDbContext _db;

        public StudentServices(AppDbContext db)//constructor must have the same name as our class
        {
            _db = db;

            //When our SutendsServices class is called
            // the constructor runs automatically
            //We pass in our database as a parameter and ser inside of our _db variable
        } 

        public List<Student> GetAll()
        {
            return _db.Students.ToList();
        }

        public Student AddStudent(Student newstudent)
        {
            newstudent.Id =0;

            _db.Students.Add(newstudent);
            _db.SaveChanges();
        
            return newstudent;
        }

        
    }
}