using Microsoft.AspNetCore.Mvc;

namespace Zwierzaki.Controllers


{
    [Route("api/[controller]")]
    [ApiController]
    public class WizytyController : ControllerBase
    {
        [HttpGet ("{id}")]
        public IActionResult Get(int id)
        {
            var wizyts = Database.Wizytas.FindAll(x => x.animalId == id);
            return Ok(wizyts);
        }

        [HttpPost]
        public IActionResult Add(Wizyta wizyta)
        {
            Database.Wizytas.Add(wizyta);
            return Created();
        }
        
    }
}