using LibraryApi.DTOs.Book;
using LibraryApi.Models;

namespace LibraryApi.Mappers
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