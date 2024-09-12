using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApi.DTOs.Book;
using LibraryManagementSystemWithAPI.API;

namespace LibraryManagementSystemWithAPI.UI
{
    public partial class BorrowBookMenu : Form
    {
        public BorrowBookMenu()
        {
            InitializeComponent();
        }
        private async void BorrowBookMenu_Load(object sender, EventArgs e)
        {
            HttpClient _httpClient = new HttpClient();
            HttpResponseMessage response = await _httpClient.GetAsync("http://localhost:5069/api/book");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                //burda sorun var:
                var books = JsonSerializer.Deserialize<List<BookResponseDTO>>(responseBody);
                //
                label1.Text = books[1].Author;
                dgvBorrowedBooks.DataSource = books.ToList();
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                
            }
        }

    }
}
