using Microsoft.AspNetCore.Mvc;

namespace ParkApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParksController : ControllerBase
    {
        private readonly ParkApiContext _db;

        public ParksController(ParkApiContext db)
        {
            _db = db;
        }
        // GET api/parks
        [HttpGet]
        public async Task<List<Park>> Get(string name, string location, string type)
        {
            IQueryable<Park> query = _db.Parks.AsQueryable();

            if (location != null)
            {
                query = query.Where(entry => entry.location == location);
            }

            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }

            if (type != null)
            {
                query = query.Where(entry => entry.Age >= type);
            }

            return await query.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Park>> GetPark(int id)
        {
            Park park = await _db.Parks.FindAsync(id);

            if (park == null)
            {
                return NotFound();
            }

            return park;
        }

        [HttpPost]
        public async Task<ActionResult<Park>> Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
        }

        // PUT: api/Parks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Park park)
        {
            if (id != park.ParkId)
            {
                return BadRequest();
            }

            _db.Parks.Update(park);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParkExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool ParkExists(int id)
        {
            return _db.Parks.Any(e => e.ParkId == id);
        }

        // DELETE: api/Parks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePark(int id)
        {
            Park park = await _db.Parks.FindAsync(id);
            if (park == null)
            {
                return NotFound();
            }

            _db.Parks.Remove(park);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
