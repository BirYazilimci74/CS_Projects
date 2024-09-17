﻿using LibraryManagementSystemWithAPI.API;
using LibraryManagementSystemWithAPI.DTOs.BorrowedBook;
using LibraryManagementSystemWithAPI.Mappers;

namespace LibraryManagementSystemWithAPI.UI
{
    public partial class BorrowBookMenu : Form
    {
        private readonly BookOperations _bookOperations;
        private readonly BorrowedBookOperations _borrowedBookOperations;
        public BorrowBookMenu(BookOperations bookOperations, BorrowedBookOperations borrowedBookOperations)
        {
            InitializeComponent();
            _bookOperations = bookOperations;
            _borrowedBookOperations = borrowedBookOperations;
        }
        private async void BorrowBookMenu_Load(object sender, EventArgs e)
        {
            await LoadBooksAsync();
        }

        private async Task LoadBooksAsync()
        {
            var books = await _bookOperations.GetAllAsync();
            dgvBooks.DataSource = books.Select(b => b.ToBookResponseDTO()).ToList();
            
            if (dgvBooks.Columns.Contains("Id"))
            {
                dgvBooks.Columns["Id"].Visible = false;
            }
        }

        private async void btnBorrow_Click(object sender, EventArgs e)
        {
            int selectedBookId = DetermineSelectedBookId();
            await BorrowSelectedBookById(selectedBookId);
            await LoadBooksAsync();
        }

        private int DetermineSelectedBookId()
        {
            int selectedRow = dgvBooks.SelectedRows[0].Index;
            int selectedBookId = Convert.ToInt32(dgvBooks.Rows[selectedRow].Cells[0].Value);
            return selectedBookId;
        }

        private async Task BorrowSelectedBookById(int id)
        {
            await _bookOperations.BorrowSelectedBookById(id);
            await _borrowedBookOperations.AddBorrowedBookAsync(new BorrowedBookDTO() { BookID = id });
        }
    }
}
