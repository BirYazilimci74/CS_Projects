using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using MyLocalServerAPI.Contexts;

namespace MyLocalServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ToDoDbContext _context;

        public CarsController(ToDoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetCars()
        {
            var cars = _context.Cars.ToList();
            return Ok(cars);
        }
    }
}