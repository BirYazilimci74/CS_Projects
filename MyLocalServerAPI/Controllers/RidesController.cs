using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using MyLocalServerAPI.Contexts;

namespace MyLocalServerAPI.Controllers;

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
}