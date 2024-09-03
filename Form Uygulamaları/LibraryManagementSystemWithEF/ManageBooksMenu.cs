using System;
using System.Linq;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.DAL;
using LibraryManagementSystemWithEF.Models;
using ZstdSharp.Unsafe;

namespace LibraryManagementSystemWithEF
{
    public partial class ManageBooksMenu : Form
    {
        private readonly IBookService _bookService = Services.BookService;
        private readonly ICategoryService _categoryService = Services.CategoryService;
        public ManageBooksMenu()
        {
            InitializeComponent();
        }

        private void ManageBooksMenu_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategory(cmbAddCategory);
            LoadCategory(cmbUpdateCategory);
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = _bookService.TGetBooksWithCategoryName();
        }

        private void ClearTextBoxes()
        {
            tbxAddName.Text = string.Empty;
            tbxAddAuthor.Text = string.Empty;
            tbxAddStock.Text = string.Empty;
            tbxUpdateName.Text = string.Empty;
            tbxUpdateAuthor.Text = string.Empty;
            tbxUpdateStock.Text = string.Empty;
        }
        private void LoadCategory(ComboBox comboBox)
        {
            var categories= _categoryService.TGetAll().Select(c => c.Name).ToList();

            comboBox.DataSource = categories;
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateAuthor.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            cmbUpdateCategory.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateStock.Text = dgvBooks.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _bookService.TDelete(new Book()
            {
                Id = Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value),
                Name = dgvBooks.CurrentRow.Cells[1].Value.ToString(),
                Author = dgvBooks.CurrentRow.Cells[2].Value.ToString(),
                CategoryId = _categoryService.TGetAll()
                    .FirstOrDefault(c => c.Name == cmbUpdateCategory.SelectedItem.ToString()).Id,
                Stock = Convert.ToInt32(dgvBooks.CurrentRow.Cells[4].Value),
            });
            LoadBooks();
            ClearTextBoxes();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            var bookToUpdate = new Book()
            {
                Id = Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value),
                Name = tbxUpdateName.Text,
                Author = tbxUpdateAuthor.Text,
                CategoryId = _categoryService.TGetAll()
                    .FirstOrDefault(c => c.Name == cmbUpdateCategory.SelectedItem.ToString()).Id,
                Stock = Convert.ToInt32(tbxUpdateStock.Text),
            };
            _bookService.TUpdate(bookToUpdate);
            //_bookService.TAdd(bookToUpdate);
            LoadBooks();
            ClearTextBoxes();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var bookToAdd = new Book()
            {
                Name = tbxAddName.Text,
                Author = tbxAddAuthor.Text,
                CategoryId = _categoryService.TGetAll().FirstOrDefault(c => c.Name == cmbAddCategory.SelectedItem.ToString()).Id,
                Stock = Convert.ToInt32(tbxAddStock.Text),
            };
            _bookService.TAdd(bookToAdd);
            LoadBooks();
            ClearTextBoxes();
        }
    }
}
