using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Day_Ten_APIs_Continued.Models;
using Day_Ten_APIs_Continued.Services;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;

namespace Day_Ten_APIs_Continued.Controllers
{
    [ApiController]
    [Route("api/[controller]")]//api/cargo
    public class CargoController : ControllerBase
    {
        //Constructor runs once when this method is called
        private readonly ICargoServices _cargo; //declaring empty cargoservices
        //readonly means it can never be reassigned


        // public controller(Icargoservices controller)
        public CargoController(ICargoServices cargo)
        {
            // we are injecting our services into our controller to gain access to the method
            _cargo = cargo;
        }

        [HttpGet("GetAll")]
        public ActionResult GetAllCargo()
        {
            return Ok(_cargo.GetAll());
        }

        [HttpGet("GetByCategory/{category}")]
        public ActionResult<List<CargoItem>> GetByCategory(string category)
        {
            List<CargoItem> items = _cargo.GetByCategory(category);

            return Ok(items);
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<CargoItem> GetById(int id)
        {
            CargoItem item = _cargo.GetById(id);

            if (item == null)
            {
                return NotFound($"No item found with id {id}");
            }

            return Ok(item);
        }

        [HttpPost("Create")]
        public ActionResult<CargoItem> Create([FromBody] CargoItem item)
        {
            CargoItem newItem = _cargo.Create(item);

            return CreatedAtAction(
                //nameof points to where we can find the item
                //new setting that is inside of our url. /api/cargo/getbyid/(newid)
                nameof(GetById),
                new { id = newItem.Id },
                newItem
            );
        }

        [HttpPut("Update/{id}")]
        public ActionResult<bool> UpdateCargo(int id, CargoItem item)
        {
            bool updated = _cargo.Update(id, item);
            if (updated == false)
            {
                return NotFound($"No item found with id {id}");
            }

            return NoContent();//204 it worked and nothing will display
            }

        [HttpDelete("Delete")]
        public ActionResult<bool> DeleteItem (int id)
        {
            bool deleted = _cargo.Delete(id);
            if (deleted == false)
            {
                return NotFound($"No cargo item with that id {id}");
            }

            return NoContent();
        }
    }
}