using System.Text.Json;
using LibraryManagementSystemWithAPI.DTOs.BorrowedBook;
using LibraryManagementSystemWithAPI.Mappers;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.API
{
    public class BorrowedBookOperations
    {
        private readonly HttpClient _httpClient;
        private const string Url = "http://localhost:5069/api/borrowedbook";

        public BorrowedBookOperations(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<BorrowedBookResponseDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(Url);
                message.EnsureSuccessStatusCode();

                string bookJson = await message.Content.ReadAsStringAsync();
                //Console.WriteLine(bookJson);
                var books = JsonSerializer.Deserialize<List<BorrowedBook>>(bookJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return books.Select(b => b.ToBorrowedBookResponseDTO()).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<BorrowedBookResponseDTO> GetByIdAsync(int id)
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(Url + $"/{id}");
                message.EnsureSuccessStatusCode();

                string bookJson = await message.Content.ReadAsStringAsync();

                var book = JsonSerializer.Deserialize<BorrowedBook>(bookJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return book.ToBorrowedBookResponseDTO();
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
