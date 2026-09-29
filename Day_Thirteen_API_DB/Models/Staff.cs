using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_Thirteen_API_DB.Models
{
    public class Staff : BaseEntity// pulls from BaseEntity so we don't need to use Id since it is in 
    {
        public string FullName {get; set;} = string.Empty;
        public string Job {get; set;} = string.Empty;
        public bool HasComputer {get; set;} = false;// we can assign values to our properties

    }
}