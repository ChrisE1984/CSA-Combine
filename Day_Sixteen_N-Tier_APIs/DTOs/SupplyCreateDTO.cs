//What a client is allowed to SEND
//This will have no ID (our DB picks it anyway) and no StorageLocation (that is ours)
//Even if the client wants to set those properties they cannot because we don't have them
using System.ComponentModel.DataAnnotations;

namespace Day_Sixteen_N_Tier_APIs.DTOs
{
    public class SupplyCreateDTO
    {

        //Attributes are characteristics of or properties
        [Required(ErrorMessage = "Every supply needs a name.")]
        public string Name {get;set;}=string.Empty;
        [Range(1,10000, ErrorMessage = "Quantity must be from 1-10000")]
        public int Quantity {get;set;}
    }
}