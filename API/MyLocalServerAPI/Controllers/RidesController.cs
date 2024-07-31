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
}