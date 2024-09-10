using LibraryApi.DTOs.BorrowedBook;
using LibraryApi.Models;

namespace LibraryApi.Mappers
{
    public static class BorrowedBookMapper
    {
        public static BorrowedBookResponseDTO ToBorrowedBookResponseDTO(this BorrowedBook borrowedBook)
        {
            return new BorrowedBookResponseDTO
            {
                BookName = borrowedBook.Book?.Name ?? "Unknown Book",
                BorrewedTime = borrowedBook.BorrewedTime,
                ReturnTime = borrowedBook.ReturnTime,
            };
        }

        public static BorrowedBookRequestDTO ToBorrowedBookRequestDTO(this BorrowedBook borrowedBook)
        {
            return new BorrowedBookRequestDTO
            {
                Id = borrowedBook.Id,
                BorrewedTime = borrowedBook.BorrewedTime,
                ReturnTime = borrowedBook.ReturnTime,
            };
        }
    }
}