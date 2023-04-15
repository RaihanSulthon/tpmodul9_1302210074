using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302210074.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa2 : ControllerBase
    {
        public static List<Mahasiswa> a = new List<Mahasiswa>
        {
            new Mahasiswa ("Raihan Sulthon Yaafi", "1302210074"),
            new Mahasiswa ("Fasya Raihan Maulana","1302213116"),
            new Mahasiswa ("Rizki Muhammad Ridwan", "1302210097"),
            new Mahasiswa ("Mochammad Rifqi Barliant", "1302210125"),
            new Mahasiswa ("Reza Adhie Dharmawan", "1302213016"),
            new Mahasiswa ("Muhammad Zaky Fathurahim", "1302213067")

        };
        // GET: api/<Mahasiswa2>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return a;
        }

        // GET api/<Mahasiswa2>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            if (id < 0 || id >= a.Count)
            {
                NotFound();
            }
            return a[id];
        }

        // POST api/<Mahasiswa2>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            a.Add(value);
        }

        // DELETE api/<Mahasiswa2>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= a.Count)
            {
                NotFound();
            }
            a.RemoveAt(id);
        }
    }
}
