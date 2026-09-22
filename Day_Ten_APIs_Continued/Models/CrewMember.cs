// A model is just a normal C# class that describes one thing your API works with
// This will describe the shape of our data for our Crew Members
namespace Day_Ten_APIs_Continued.Models
{
    public class CrewMember
    {
        public int Id {get; set; }// Every item needs a unique id so clients can address it
        public string Name {get; set; }// get allows you to give this property value, set allows us to change it//Pascal Case
        public string Rank {get; set; }
        public string Sector {get; set; }
        public bool IsOnDuty {get; set; }
    }
}

//CrewMember crew = new CrewMember();
//crew.Name = "Chris";<-this would be a set
//Console.WriteLine(crew.Name)<- this is a get