using System.Text.Json;
using System.Threading.Tasks;
using LibraryApi.DTOs.Book;
using LibraryApi.Models;

namespace LibraryManagementSystemWithAPI.API
{
    public class BookOperations
    {
        private readonly HttpClient _httpClient;
        private const string URL = "http://localhost:5069/api/book";
        public BookOperations(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<BookResponseDTO>> GetAllAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                var books = JsonSerializer.Deserialize<List<BookResponseDTO>>(responseBody);
                return books;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                return new List<BookResponseDTO>();
            }
        }

        public Book GetById(int id)
        {
            return new Book();
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
