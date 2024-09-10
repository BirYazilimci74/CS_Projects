using LibraryApi.Contexts;
using LibraryApi.DTOs.Book;
using LibraryApi.Mappers;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly LibraryDBContext _context;
        public BookController(LibraryDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _context.Books.Include(b => b.Category).ToList().Select(b => b.ToBookResponseDTO());
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            var book = _context.Books.Include(b => b.Category).FirstOrDefault(b => b.Id == id);

            if (book is null)
            {
                return NotFound();
            }
            return Ok(book.ToBookResponseDTO());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var bookToDelete = _context.Books.Find(id);

            if (bookToDelete is null)
            {
                return NotFound();
            }
            _context.Books.Remove(bookToDelete);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult Add([FromBody]BookRequestDTO book)
        {
            
            if (book is not null)
            {
                _context.Books.Add(book.ToBook());
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest("Book couldn't added!!!");
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute]int id,[FromBody]Book book)
        {
            var bookToUpdate = _context.Books.Find(id);

            if (bookToUpdate is null)
            {
                return NotFound();
            }
            bookToUpdate.Name = book.Name;
            bookToUpdate.Author = book.Author;
            bookToUpdate.CategoryId = book.CategoryId;
            bookToUpdate.Stock = book.Stock;
            _context.SaveChanges();
            return Ok();
        }
    }
}