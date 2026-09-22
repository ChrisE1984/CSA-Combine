
using Day_Ten_APIs_Continued.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_Ten_APIs_Continued.Controllers
{
    [ApiController]
    [Route("api/[controller]")]//api/crew endpoint
    public class CrewController : ControllerBase
    {
        //OUR DATABASE FOR TODAY
        //A Static means one shared copy for the whole application, so that data survives between requests. 
        // Any adds, updates, deletes will not and list will revert to original list
        static List<CrewMember> Crew = [
            new CrewMember {Id = 1, Name = "Isaiah Ferguson", Rank = "Commander", Sector = "Command", IsOnDuty = true},
            new CrewMember {Id = 2, Name = "Chris Estrada", Rank = "Engineer", Sector = "Engineering", IsOnDuty = true},
            new CrewMember {Id = 3, Name = "Zackary Santos", Rank = "Medic", Sector = "Medical", IsOnDuty = false}
        ];
        //This tracks the next Id to handout
        private static int _nextId = 4;

        [HttpGet("GetAllMembers")]
        public ActionResult<List<CrewMember>> GetAll()
        {
            //return 200 Ok with whole list
            return Ok(Crew);
        }

        [HttpGet("getmember/{id}")]
        public ActionResult<CrewMember> GetByID (int id)
        {
            //FirstOrDefault returns null when nothing matches
            //=> is a one Liner for a method that returns the conditioned value
            CrewMember? member = Crew.FirstOrDefault(c => c.Id == id);

            if (member == null)
            {
                return NotFound ($"No crew member with id {id}.");
            }

            return Ok(member);
        }
        [HttpPost("Create")]
        public ActionResult<CrewMember> Create([FromBody] CrewMember incoming)
        {
           incoming.Id = _nextId;
           _nextId ++;

           Crew.Add(incoming);

           //201 Created is the correct status "I made something  new"
            return CreatedAtAction(
                actionName: nameof(GetByID),            //which action to get new created data
                routeValues: new { id = incoming.Id },   // fill the {id} in the action route
                value: incoming                         // the body to send back

            );
        }
        //REPLACE - UP

        //Put replaces the whole record(CrewMember) The Client sends every field
        [HttpPut("Update/{id}")]
        public ActionResult<bool> Update(int id, [FromBody] CrewMember incoming)
        {
            CrewMember? member = Crew.FirstOrDefault(c => c.Id == id);// c is parameter and could be anything

            if (member == null)
            {
                return NotFound($"No crew member found with id {id}");
            }
            //Copy each field across. We deliberately do not copy the id.
            member.Name = incoming.Name;
            member.Rank = incoming.Rank;
            member.Sector = incoming.Sector;
            member.IsOnDuty = incoming.IsOnDuty;

            return Ok(true);
        }

        [HttpDelete("delete/{id}")]
        public ActionResult<bool> Delete(int id)
        {
            //? means that member can be null
            CrewMember? member = Crew.FirstOrDefault(c => c.Id == id);
                
            if(member == null)
            {
                return NotFound($"No crew member with id {id}");
            }
            
            Crew.Remove(member);

            return Ok(true);
        }
    }
}