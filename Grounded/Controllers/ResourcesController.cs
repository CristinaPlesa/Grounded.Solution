using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Grounded.Models;

namespace Grounded.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        private readonly GroundedContext _db;

        public ResourcesController(GroundedContext db)
        {
            _db = db;
        }

        // GET: api/Resources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Resource>>> Get(string resourceName)
        {
        var query = _db.Resources.AsQueryable();

        if (resourceName != null)
        {
            query = query.Where(entry => entry.ResourceName == resourceName);
        }   

        return await query.ToListAsync();
        }

        // GET: api/Resources/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Resource>> GetResource(int id)
        {
            var resource = await _db.Resources.FindAsync(id);

            if (resource == null)
            {
                return NotFound();
            }

            return resource;
        }

        // PUT: api/Resources/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResource(int id, Resource resource)
        {
            if (id != resource.ResourceId)
            {
                return BadRequest();
            }

            _db.Entry(resource).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResourceExists(id))
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

        // POST: api/Resources
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Resource>> PostResource(Resource resource)
        {
            _db.Resources.Add(resource);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetResource", new { id = resource.ResourceId }, resource);
        }

        // DELETE: api/Resources/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResource(int id)
        {
            var resource = await _db.Resources.FindAsync(id);
            if (resource == null)
            {
                return NotFound();
            }

            _db.Resources.Remove(resource);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool ResourceExists(int id)
        {
            return _db.Resources.Any(e => e.ResourceId == id);
        }
    }
}
