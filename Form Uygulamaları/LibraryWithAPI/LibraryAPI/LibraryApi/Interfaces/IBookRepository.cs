using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApi.DTOs.Book;
using LibraryApi.Models;

namespace LibraryApi.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task<Book> AddAsync(Book book);
        Task<Book?> UpdateAsync(int id,BookRequestDTO book);
        Task<Book?> DeleteAsync(int id);
    }
}