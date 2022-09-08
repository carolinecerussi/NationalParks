using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParks.Models;

namespace NationalParks.Controllers
{
	[Route ("api/[controller]")]
  [ApiController]
  public class NationalParksController : ControllerBase
  {
    private readonly NationalParksContext _db;

    public NationalParksController(NationalParksContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<NationalPark>>> Get()
    {
      return await _db.NationalParks.ToListAsync();
    }
    [HttpPost]
    public async Task<ActionResult<NationalPark>> Post(NationalPark nationalPark)
    {
      _db.NationalParks.Add(nationalPark);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = nationalPark.ParkId }, nationalPark);
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<NationalPark>> GetNationalPark(int id)
		{
    var nationalPark = await _db.NationalParks.FindAsync(id);

    if (nationalPark == null)
    {
        return NotFound();
    }
    return nationalPark;
		}
		
	[HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, NationalPark nationalPark)
    {
      if (id != nationalPark.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(nationalPark).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!NationalParkExists(id))
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
          private bool NationalParkExists(int id)
    {
      return _db.NationalParks.Any(e => e.ParkId == id);
    }

		[HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var nationalPark = await _db.NationalParks.FindAsync(id);
      if (nationalPark == null)
      {
        return NotFound();
      }
			
			_db.NationalParks.Remove(nationalPark);
      await _db.SaveChangesAsync();

      return NoContent();

		}

    private bool ParkExists(int id)
    {
      return _db.NationalParks.Any(e => e.ParkId == id);
    }
	}
}
