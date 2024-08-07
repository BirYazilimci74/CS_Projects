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
    public ActionResult<Ride> AddRide(Ride ride)
    {
        if (ride is null)
        {
            return BadRequest("Ride is NULL");
        }

        _context.Rides.Add(ride);
        _context.SaveChanges();

        return NoContent();
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

    [HttpDelete("{id}")]
    public ActionResult<Ride> Delete(int id)
    {
        var rideToDelete = _context.Rides.FirstOrDefault(r => r.Id == id);
        
        if (rideToDelete is null)
        {
            return NotFound();
        }

        _context.Rides.Remove(rideToDelete);
        _context.SaveChanges();
        
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateRide(int id, Ride updatedRide)
    {
        var rideToUpdate = _context.Rides.FirstOrDefault(r => r.Id == id);

        if (rideToUpdate is null)
        {
            return NotFound();
        }

        rideToUpdate.DriverName = updatedRide.DriverName ?? rideToUpdate.DriverName;
        rideToUpdate.Target = updatedRide.Target ?? rideToUpdate.Target;
        rideToUpdate.Plate = updatedRide.Plate ?? rideToUpdate.Plate;
        rideToUpdate.Latitude = updatedRide.Latitude;
        rideToUpdate.Longitude = updatedRide.Longitude;

        _context.SaveChanges();
        return NoContent();
    }
    
    
}