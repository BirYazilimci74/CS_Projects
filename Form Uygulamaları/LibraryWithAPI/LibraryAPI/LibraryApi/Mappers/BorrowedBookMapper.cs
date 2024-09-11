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
                BorrewedTime = borrowedBook.BorrewedTime,
                ReturnTime = borrowedBook.ReturnTime,
                BookID = borrowedBook.BookID,
            };
        }

        public static BorrowedBook ToBorrowedBook(this BorrowedBookRequestDTO borrowedBookRequestDTO)
        {
            return new BorrowedBook
            {
                BorrewedTime = borrowedBookRequestDTO.BorrewedTime,
                ReturnTime = borrowedBookRequestDTO.ReturnTime,
                BookID = borrowedBookRequestDTO.BookID,
            };
        }
    }
}