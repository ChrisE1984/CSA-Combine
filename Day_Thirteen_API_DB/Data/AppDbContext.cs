using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_Thirteen_API_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace Day_Thirteen_API_DB.Data
{
    public class AppDbContext : DbContext// Db Context is our connection to the Database
    {
        //Constructor runs automatically when a class is called
        // method and class share same name
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        //this IS the Students table as  far as our C# code is concerned
        public DbSet<Student> Students {get; set;}
    }

    
}