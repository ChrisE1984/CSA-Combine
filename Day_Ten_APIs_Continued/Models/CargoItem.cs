//This model will create one crate of cargo

//you can think of it as a form of an object
namespace Day_Ten_APIs_Continued.Models
{
    public class CargoItem
    {
        public int Id{get; set; }// get allows us to read, set allows us tot change value
        public string Name {get; set; }
        public string Category {get; set; }
        public decimal Masskg { get; set; }
    }
}