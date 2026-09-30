using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_Sixteen_N_Tier_APIs.DTOs;
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
        public ActionResult<List<SupplyReadDTO>> GetAll()
        {
            return Ok(_supplies.GetAll());
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<SupplyReadDTO> GetById(int id)
        {//we are returning our DTO and NOT our Model because we do not want the location leaking
            SupplyReadDTO? supply = _supplies.GetById(id);

            if (supply == null)
            {
                return NotFound($"No supply with id {id}");
            }
            return Ok(supply);
        }
        //[ApiController] checks the DTO attributes [Required] and [Range] before the method runs
        // any non name or bad quantity The user gets an automatic 400
        [HttpPost("Create")]
        public ActionResult<SupplyReadDTO> Create([FromBody] SupplyCreateDTO supply)
        {
            SupplyReadDTO? created = _supplies.Create(supply);

            if (created == null)
            {
                //This is stating there is a conflict with the information that is sent and the DB
                return Conflict($"There is already a supply called {supply.Name}.");//409
            }

            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }



        [HttpPut("Withdraw/{id}/{amount}")]
        public ActionResult<SupplyReadDTO> Withdraw(int id, int amount)
        {
            SupplyReadDTO? supply = _supplies.GetById(id);

            if (supply == null)
            {
                return NotFound($"No supply with id {id}");
            }

            bool ok = _supplies.Withdraw(id, amount);

            if (ok == false)
            {
                return BadRequest($"Cannot withdraw {amount}. There are {supply.Quantity} on the shelf.");
            }

            return Ok(true);
        }
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {

            if (_supplies.GetById(id) == null)

            {
                return NotFound($"No supply exists with id {id}");
            }

            _supplies.Delete(id);
            return NoContent();
        }

    }
}