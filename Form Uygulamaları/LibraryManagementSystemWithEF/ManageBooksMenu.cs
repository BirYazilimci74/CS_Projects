using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF
{
    public partial class ManageBooksMenu : Form
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        public ManageBooksMenu(IBookService bookService, ICategoryService categoryService)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            InitializeComponent();
        }

        private async void ManageBooksMenu_Load(object sender, EventArgs e)
        {
            await LoadBooksAsync();
            await LoadCategoryAsync(cmbAddCategory);
            await LoadCategoryAsync(cmbUpdateCategory);
        }

        private async Task LoadBooksAsync()
        {
            try
            {
                var booksWithCategoryName = await Task.Run(() => _bookService.TGetBooksWithCategoryName());
                dgvBooks.DataSource = booksWithCategoryName;
            }
            catch
            {
                MessageBox.Show("The Books Couldn't Load", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void ClearTextBoxes()
        {
            tbxAddName.Clear();
            tbxAddAuthor.Clear();
            tbxAddStock.Clear();
            tbxUpdateName.Clear();
            tbxUpdateAuthor.Clear();
            tbxUpdateStock.Clear();
        }
        private async Task LoadCategoryAsync(ComboBox comboBox)
        {
            try
            {
                var categories = await Task.Run(() => _categoryService.TGetAll().Select(c => c.Name).ToList());
                comboBox.DataSource = categories;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedBooks = dgvBooks.Rows[e.RowIndex];
                tbxUpdateName.Text = selectedBooks.Cells[1].Value.ToString();
                tbxUpdateAuthor.Text = selectedBooks.Cells[2].Value.ToString();
                cmbUpdateCategory.Text = selectedBooks.Cells[3].Value.ToString();
                tbxUpdateStock.Text = selectedBooks.Cells[4].Value.ToString();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await DeleteSelectedBookAsync();
            await LoadBooksAsync();
            ClearTextBoxes();
        }

        private async Task DeleteSelectedBookAsync()
        {
            int categoryId = _categoryService.TGetAll()
                .FirstOrDefault(c => c.Name == cmbUpdateCategory.SelectedItem.ToString()).Id;

            var bookToDelete = new Book()
            {
                Id = Convert.ToInt32(dgvBooks.CurrentRow?.Cells[0].Value),
                Name = dgvBooks.CurrentRow?.Cells[1].Value.ToString(),
                Author = dgvBooks.CurrentRow?.Cells[2].Value.ToString(),
                CategoryId = categoryId,
                Stock = Convert.ToInt32(dgvBooks.CurrentRow?.Cells[4].Value),
            };

            try
            {
                await Task.Run(() => _bookService.TDelete(bookToDelete));
            }
            catch
            {
                MessageBox.Show("The Book Couldn't Deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            await UpdateSelectedBookAsync();
            await LoadBooksAsync();
            ClearTextBoxes();
        }

        private async Task UpdateSelectedBookAsync()
        {
            int categoryId = _categoryService.TGetAll()
                .FirstOrDefault(c => c.Name == cmbUpdateCategory.SelectedItem.ToString()).Id;
            
            var bookToUpdate = new Book()
            {
                Id = Convert.ToInt32(dgvBooks.CurrentRow?.Cells[0].Value),
                Name = tbxUpdateName.Text,
                Author = tbxUpdateAuthor.Text,
                CategoryId = categoryId,
                Stock = Convert.ToInt32(tbxUpdateStock.Text),
            };

            try
            {
                await Task.Run(() => _bookService.TUpdate(bookToUpdate));
            }
            catch
            {
                MessageBox.Show("The Book Couldn't Updated!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            await AddBookAsync();
            await LoadBooksAsync();
            ClearTextBoxes();
        }

        private async Task AddBookAsync()
        {
            int categoryId = _categoryService.TGetAll()
                .FirstOrDefault(c => c.Name == cmbAddCategory.SelectedItem.ToString()).Id;

            var bookToAdd = new Book()
            {
                Name = tbxAddName.Text,
                Author = tbxAddAuthor.Text,
                CategoryId = categoryId,
                Stock = Convert.ToInt32(tbxAddStock.Text),
            };

            try
            {
                await Task.Run(() => _bookService.TAdd(bookToAdd));
            }
            catch
            {
                MessageBox.Show("The Book Couldn't Added!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }
    }
}
