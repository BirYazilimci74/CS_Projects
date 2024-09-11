using LibraryApi.DTOs.BorrowedBook;
using LibraryApi.Models;

namespace LibraryApi.Interfaces
{
    public interface IBorrowedBookRepository
    {
        Task<List<BorrowedBook>> GetAllAsync();
        Task<BorrowedBook?> GetByIdAsync(int id);
        Task<BorrowedBook> AddAsync(BorrowedBookRequestDTO borrowedBook);
        Task<BorrowedBook?> UpdateAsync(int id,BorrowedBookRequestDTO book);
        Task<BorrowedBook?> DeleteAsync(int id);
    }
}