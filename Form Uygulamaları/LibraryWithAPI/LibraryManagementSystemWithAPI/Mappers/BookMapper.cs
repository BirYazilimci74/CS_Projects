using LibraryManagementSystemWithAPI.DTOs.Book;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.Mappers
{
    public static class BookMapper
    {
        public static BookResponseDTO ToBookResponseDTO(this Book bookModel)
        {
            return new BookResponseDTO
            {
                Name = bookModel.Name ?? string.Empty,
                Author = bookModel.Author ?? string.Empty,
                CategoryName = bookModel.Category?.Name ?? "Unknown",
                Stock = bookModel.Stock,
            };
        }

        public static BookRequestDTO ToBookRequestDTO(this Book bookModel)
        {
            return new BookRequestDTO
            {
                Name = bookModel.Name,
                Author = bookModel.Author,
                CategoryId = bookModel.CategoryId,
                Stock = bookModel.Stock,
            };
        }

        public static Book ToBook (this BookRequestDTO bookRequestDTO)
        {
            return new Book
            {
                Name = bookRequestDTO.Name,
                Author = bookRequestDTO.Author,
                CategoryId = bookRequestDTO.CategoryId,
                Stock = bookRequestDTO.Stock,
            };
        }
    }
}