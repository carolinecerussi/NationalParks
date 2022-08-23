using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParks.Models;

namespace NationalParks.Controllers
{
  [Route("api/[controller]")]
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
  }
}