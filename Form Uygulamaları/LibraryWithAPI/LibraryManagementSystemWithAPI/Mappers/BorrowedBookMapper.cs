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

        public static BorrowedBookDTO ToBorrowedBookDTO(this BorrowedBook borrowedBook)
        {
            return new BorrowedBookDTO
            {
                BookID = borrowedBook.BookID,
                BorrewedTime = borrowedBook.BorrewedTime,
                ReturnTime = borrowedBook.ReturnTime,
            };
        }

        public static BorrowedBook ToBorrowedBook(this BorrowedBookDTO borrowedBookRequestDTO)
        {
            return new BorrowedBook
            {
                BookID = borrowedBookRequestDTO.BookID,
                BorrewedTime = borrowedBookRequestDTO.BorrewedTime,
                ReturnTime = borrowedBookRequestDTO.ReturnTime,
            };
        }
    }
}