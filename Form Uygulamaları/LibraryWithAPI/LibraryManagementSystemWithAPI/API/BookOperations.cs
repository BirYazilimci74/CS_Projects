using System.Text.Json;
using System.Threading.Tasks;
using LibraryApi.DTOs.Book;
using LibraryApi.Models;

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

        public async Task<List<Book>> GetAllAsync()
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

                return books;
            }
            catch (Exception ex)
            {
                throw;
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
