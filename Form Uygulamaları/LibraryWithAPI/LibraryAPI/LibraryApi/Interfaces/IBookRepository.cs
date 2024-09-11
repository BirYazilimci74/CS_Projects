using LibraryApi.DTOs.Book;
using LibraryApi.Models;

namespace LibraryApi.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task<Book> AddAsync(BookRequestDTO book);
        Task<Book?> UpdateAsync(int id,BookRequestDTO book);
        Task<Book?> DeleteAsync(int id);
    }
}