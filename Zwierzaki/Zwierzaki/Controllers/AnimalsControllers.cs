using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace Zwierzaki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // 1
        [HttpGet]
        public IActionResult Get()
        {
            var animals = Database.Animals;
            return Ok(animals);
        }
        /*// 2
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var animal = Database.Animals.FirstOrDefault(x => x.id == id);
            return Ok(animal);
        }*/
        // 3
        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            Database.Animals.Add(animal);
            return Created();
        }
        // 4
        [HttpPut("{id}")]
        public IActionResult Change(int id, [FromBody] Animal animal)
        {
            var ani = Database.Animals.FirstOrDefault(x => x.id == id);
            if (ani == null)
            {
                return NotFound();
            }
            ani.kategoria = animal.kategoria;
            ani.kolorSiersci = animal.kolorSiersci;
            ani.imie = animal.imie;
            ani.masa = animal.masa;
            return Ok(ani);
        }
        // 5

        [HttpDelete("{id}")]
        public IActionResult Usun(int id)
        {
            var animal = Database.Animals.FirstOrDefault(x => x.id == id);
            if (animal == null)
            {
                return NotFound();
            }

            var remove = Database.Animals.Remove(animal);

            return Ok(); // co tutaj zwrócic ?
        }
        
        // 6 
        [HttpGet("{imie}")]
        public IActionResult Search(String imie)
        {
            var animals = Database.Animals.FindAll(x => x.imie.Equals(imie));
            return Ok(animals);
        }
        
        

    }
}
