using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_Sixteen_N_Tier_APIs.Models
{
    public class Supply
    {
        //when creating an entity we always need a unique id
        public int Id {get; set;}
        public string Name {get; set;} = string.Empty;

        public int Quantity {get; set;}
        //StorageLocation is Internal Only, the Client never sees it
        public string StorageLocation {get;set;} =string.Empty;

    }
}