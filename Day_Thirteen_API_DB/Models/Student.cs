using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace Day_Thirteen_API_DB.Models
{
    public class Student
    {
        public int Id {get; set;}
        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Email {get; set;}
    }
}

//Student student = new Student
//Student.FirstName = "Isaiah" {this is the set}
// return Student.LastName {get}