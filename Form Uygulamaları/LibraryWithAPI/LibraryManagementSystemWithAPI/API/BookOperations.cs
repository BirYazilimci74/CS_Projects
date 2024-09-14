using System.Text.Json;
using LibraryManagementSystemWithAPI.DTOs.Book;
using LibraryManagementSystemWithAPI.Mappers;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.API
{
    public class BookOperations
    {
        private readonly HttpClient _httpClient;
        private const string Url = "http://localhost:5069/api/book";
        public BookOperations(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<BookResponseDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(Url);
                message.EnsureSuccessStatusCode();

                string bookJson = await message.Content.ReadAsStringAsync();
                //Console.WriteLine(bookJson);
                var books = JsonSerializer.Deserialize<List<Book>>(bookJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return books.Select(b => b.ToBookResponseDTO()).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<BookResponseDTO> GetByIdAsync(int id)
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(Url + $"/{id}");
                message.EnsureSuccessStatusCode();

                string bookJson = await message.Content.ReadAsStringAsync();

                var book = JsonSerializer.Deserialize<Book>(bookJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return book.ToBookResponseDTO();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public void Add()
        {

        }
    }
}
