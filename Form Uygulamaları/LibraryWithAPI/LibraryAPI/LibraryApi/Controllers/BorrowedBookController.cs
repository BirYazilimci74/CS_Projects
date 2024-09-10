using LibraryApi.Contexts;
using LibraryApi.Mappers;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Controllers
{
    [Route("api/borrowedbook")]
    [ApiController]
    public class BorrowedBookController : ControllerBase
    {
        private readonly LibraryDBContext _context;
        public BorrowedBookController(LibraryDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var borrowedBooks = _context.BorrowedBooks
            .Include(bb => bb.Book)
            .ToList()
            .Select(bb => bb.ToBorrowedBookResponseDTO());
            
            return Ok(borrowedBooks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            var borrowedBook = _context.BorrowedBooks
            .Include(bb => bb.Book)
            .FirstOrDefault(bb => bb.Id == id);
            
            if (borrowedBook is null)
            {
                return NotFound();
            }
            return Ok(borrowedBook);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var borrowedBookToDelete = _context.BorrowedBooks.Find(id);

            if (borrowedBookToDelete is null)
            {
                return NotFound();
            }
            _context.BorrowedBooks.Remove(borrowedBookToDelete);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult Add([FromBody]BorrowedBook borrowedBook)
        {
            if (borrowedBook is not null)
            {
                _context.BorrowedBooks.Add(borrowedBook);
                _context.SaveChanges();
                return Ok();    
            }
            return BadRequest("Book couldn't borrowed");
            
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute]int id,[FromBody]BorrowedBook borrowedBook)
        {
            var borrowedBookToUpdate = _context.BorrowedBooks.Find(id);
            if(borrowedBookToUpdate is null)
            {
                return NotFound();
            }

            borrowedBookToUpdate.ReturnTime = borrowedBook.ReturnTime;
            borrowedBookToUpdate.BorrewedTime = borrowedBook.BorrewedTime;
            borrowedBookToUpdate.BookID = borrowedBook.BookID;
            _context.SaveChanges();
            return Ok();
        }
    }
}