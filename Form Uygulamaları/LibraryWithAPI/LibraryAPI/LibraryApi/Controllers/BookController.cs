using LibraryApi.Contexts;
using LibraryApi.DTOs.Book;
using LibraryApi.Interfaces;
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
        private readonly IBookRepository _bookRepository;
        public BookController(LibraryDBContext context,IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var books = await _bookRepository.GetAllAsync();
            var booksDto = books.Select(b => b.ToBookResponseDTO());
            
            return Ok(booksDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);

            if (book is null)
            {
                return NotFound();
            }
            return Ok(book.ToBookResponseDTO());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            var bookToDelete = await _bookRepository.DeleteAsync(id);

            if (bookToDelete is null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]BookRequestDTO book)
        {
            await _bookRepository.AddAsync(book.ToBook());
            return Ok();
            //return CreatedAtAction(nameof(GetById), new { id = book.Id }, book.ToBookResponseDTO());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute]int id,[FromBody]BookRequestDTO book)
        {
            await _bookRepository.UpdateAsync(id, book);

            return Ok(book.ToBook());
        }
    }
}