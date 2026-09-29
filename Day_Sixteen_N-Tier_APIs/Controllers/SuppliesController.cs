using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_Sixteen_N_Tier_APIs.Models;
using Day_Sixteen_N_Tier_APIs.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day_Sixteen_N_Tier_APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliesController : ControllerBase
    {
        private readonly ISupplyService _supplies;

        public SuppliesController(ISupplyService supplies)
        {
            _supplies = supplies;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Supply>> GetAll()
        {
            return Ok(_supplies.GetAll());
        }
        
        [HttpGet("GetById/{id}")]
        public ActionResult<Supply> GetById(int id)
        {
            Supply? supply = _supplies.GetById(id);

            if (supply == null)
            {
                return NotFound($"No supply with id {id}");
            }
            return Ok(supply);
        }

        [HttpPost("Create")]
        public ActionResult<Supply> Create ([FromBody]Supply supply)
        {
            Supply? created = _supplies.Create(supply);

            if (created == null)
            {
                return BadRequest("A supply needs a name and it's quantity cannot be below 0");
            }

                return CreatedAtAction(nameof(GetById), new {id = created.Id}, created);
        }

        [HttpPut("Withdraw/{id}/{amount}")]
        public ActionResult<Supply> Withdraw(int id, int amount)
        {
            Supply? supply = _supplies.GetById(id);

            if(supply == null)
            {
                return NotFound($"No supply with id {id}");
            }

            bool ok = _supplies.Withdraw( supply, amount);

            if(ok == false)
            {
                return BadRequest($"Cannot withdraw {amount}. There are {supply.Quantity} is on the shelf.");
            }

            return Ok(supply);
        }
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete (int id)
        {
            Supply? supply = _supplies.GetById(id);

            if (supply == null)
            {
                return NotFound($"No supply exists with id {id}");
            }

            _supplies.Delete(supply);
            return NoContent();
        }

    }
}