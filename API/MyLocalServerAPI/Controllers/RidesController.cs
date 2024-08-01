using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using API.MyLocalServerAPI.Contexts;
using API.Models;

namespace API.MyLocalServerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RidesController : ControllerBase
{
    private readonly RideShareDbContext _context;

    public RidesController(RideShareDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Ride>> GetRides()
    {
        var rides = _context.Rides.ToList();
        return Ok(rides);
    }

    [HttpPost]
    public ActionResult<Ride> PostRide([FromBody] Ride ride)
    {
        if (ride is null)
        {
            return BadRequest("Ride is NULL");
        }

        _context.Rides.Add(ride);
        _context.SaveChanges();

        return CreatedAtAction(nameof(PostRideByID), new {id = ride.Id}, ride);
    }

    [HttpPost("{id}")]
    public ActionResult<IEnumerable<Ride>> PostRideByID(int id)
    {
        var ride = _context.Rides.FirstOrDefault(r => r.Id == id);

        if (ride is null)
        {
            return NotFound();
        }
        return Ok(ride);
    }
    
    [HttpGet("{id}")]
    public ActionResult<IEnumerable<Ride>> GetRideByID(int id)
    {
        var ride = _context.Rides.FirstOrDefault(r => r.Id == id);

        if (ride is null)
        {
            return NotFound();
        }
        return Ok(ride);
    }
    
}