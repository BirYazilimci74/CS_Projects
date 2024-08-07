using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using API.MyLocalServerAPI.Contexts;
using API.Models;

namespace API.MyLocalServerAPI.Controllers
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

        [HttpPost]
        public ActionResult<Car> AddCar(Car car)
        {
            if (car == null)
            {
                return BadRequest("Car is null.");
            }

            _context.Cars.Add(car);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
            var car = _context.Cars.FirstOrDefault(c => c.Id == id);
            if (car is null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        [HttpDelete("{id}")]
        public ActionResult<Car> Delete(int id)
        {
            var carToDelete = _context.Cars.FirstOrDefault(r => r.Id == id);

            if (carToDelete is null)
            {
                return NotFound();
            }

            _context.Cars.Remove(carToDelete);
            return NoContent();
        }
    }
}