using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace Day_Thirteen_API_DB.Models
{
    public class Student : BaseEntity
    {
        public string FirstName {get; set;}= string.Empty;

        public string LastName {get; set;}= string.Empty;

        public string Email {get; set;}= string.Empty;
    }
}

//Student student = new Student
//Student.FirstName = "Isaiah" {this is the set}
// return Student.LastName {get}