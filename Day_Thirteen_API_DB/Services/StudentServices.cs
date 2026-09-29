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

        public Student Replace (int id, Student student)
        {
            //We must FIND the student that we are updating
            // and store that student and eventually change it
            Student? existingStudent = _db.Students.Find(id);// If we find something in the database EF Core tracks it

            if(existingStudent is null)
            {
                return null;
            }

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Age = student.Age;
            existingStudent.Email = student.Email;
            existingStudent.Attendance = student.Attendance;
            existingStudent.IsVaccinated = student.IsVaccinated;

            
            _db.SaveChanges();
            //when we pull an entity from our DB it is tracked and ef core knows if changes are being made to it
            //it is not a simple copy of the information
            return existingStudent;
        }
        // changes only the fields the client sent
        // fields the client left ou arrives as '' or blank/null, so blank means leave it alone
        public Student Patch (int id, Student changes)
        {
            Student? existingStudent = _db.Students.Find(id);

            if(existingStudent is null)
            {
                return null;
            }

            //if a field has a blank or whitespace we do not change
            //IsNullOrWhiteSpace is true for null, "", and "   "
                if (!string.IsNullOrWhiteSpace(changes.FirstName))
                {
                    existingStudent.FirstName = changes.FirstName;
                }
            
            if (!string.IsNullOrWhiteSpace(changes.LastName))
            {
                existingStudent.LastName = changes.LastName;
            }
        
            if (!string.IsNullOrWhiteSpace(changes.Email))
            {
                existingStudent.Email = changes.Email;
            }

            _db.SaveChanges();

            return existingStudent;
        }
    }
}