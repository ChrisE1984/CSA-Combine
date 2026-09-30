//this is what our client will get back
//the Model minus StorageLocation

namespace Day_Sixteen_N_Tier_APIs.DTOs
{
    public class SupplyReadDTO
    {
        public int Id {get;set;}
        public string Name {get;set;}=string.Empty;
        public int Quantity {get;set;}
    }
}