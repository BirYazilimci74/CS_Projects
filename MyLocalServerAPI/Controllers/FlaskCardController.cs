using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using MyLocalServerAPI.Contexts;

namespace MyLocalServerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FlaskCardController : ControllerBase
{
    private readonly ToDoDbContext _context;

    public FlaskCardController(ToDoDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<FlaskCard>> GetFlaskCards()
    {
        var flaskCards = _context.FlaskCard.ToList();
        return Ok(flaskCards);
    }
}