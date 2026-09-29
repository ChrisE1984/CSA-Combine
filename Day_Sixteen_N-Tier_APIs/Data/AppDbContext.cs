using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_Sixteen_N_Tier_APIs.Models;
using Microsoft.EntityFrameworkCore;

namespace Day_Sixteen_N_Tier_APIs.Data
{// Dbcontext
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }
        //each Db set is one table
        public DbSet<Supply> Supplies {get;set;}
    }
}