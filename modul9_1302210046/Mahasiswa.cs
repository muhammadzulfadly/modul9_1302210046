using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302210046
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : Controller
    {
        public static List<mahasiswa> mhs = new List<mahasiswa>
        {
            new mahasiswa {Name = "Muhammad Zulfadly", Nim = "1302210046", Course = new List<string>{"KPL", "Basis Data", "PBO"}, Year = 2021},
            new mahasiswa {Name = "Herlin Priatna", Nim = "1302210056", Course = new List<string>{"KPL", "Basis Data", "PBO"}, Year = 2021},
            new mahasiswa {Name = "Syahran Syahputra", Nim = "1302210066", Course = new List<string>{"KPL", "Basis Data", "PBO"}, Year = 2021},
            new mahasiswa {Name = "Afny Latifa", Nim = "1302210076", Course = new List<string>{"KPL", "Basis Data", "PBO"}, Year = 2021},
            new mahasiswa {Name = "Nurul Pratiwi", Nim = "1302210086", Course = new List<string>{"KPL", "Basis Data", "PBO"}, Year = 2021}
        };


        // GET: api/values
        [HttpGet]
        public IEnumerable<mahasiswa> Get()
        {
            return mhs;
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] mahasiswa newMhs)
        {
            mhs.Add(newMhs);
            return Ok();
        }

        // GET api/values/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id >= mhs.Count)
            {
                return NotFound();
            }

            var mhsById = mhs[id];
            return Ok(mhsById);
        }

        // DELETE api/values/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id >= mhs.Count)
            {
                return NotFound();
            }

            mhs.RemoveAt(id);
            return Ok();
        }
    }

    public class mahasiswa
    {
        public string Name { get; set; }
        public string Nim { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }
    }
}

