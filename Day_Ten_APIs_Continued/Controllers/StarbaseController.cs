using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Day_Ten_APIs_Continued.Controllers
{
    //APIController automates 400 responses
    [ApiController]
    //Base route /api this will be the base of our input
    //api/Starbase
    [Route("api/[controller]")]
    public class StarbaseController : ControllerBase
    {
       //This will be our fake DB
       List<string> sectors = ["Engineering", "Medical", "Command", "Cargo", "Docking"];

        [HttpGet ("sectors")]// Reading/Getting information from our API. can have rout information in here
        public List<string> GetSectors()//When using Controllers we do not use traditional return types like this
        {
            return sectors;
        }

        [HttpGet ("sectors/{index}")]//Route with parameter must match parameter in method
        public ActionResult<string> GetSectorInformation(int index){
        
        if(index < 0 || index > sectors.Count -1)
        {
            //if they've entered a number out of bounds they will get a 400 not found
            return NotFound($"No sector was found at the index of {index}. Please enter a number between 0 and {sectors.Count -1}");
        }
            //200 ok with the value in the response body
            return Ok(sectors[index]);
    }

    [HttpGet("Status")]
    public ActionResult<object> GetStatus()
        {
            return Ok( new
            {
              Station = "Starbase -7",
              Online = true,
              CrewCount = 8,
              CheckedAt = DateTime.UtcNow
            });
        }
}
}