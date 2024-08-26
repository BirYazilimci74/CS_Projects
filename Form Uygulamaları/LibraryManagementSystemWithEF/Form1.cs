﻿using System;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.BusinessLayer.Concrate;
using LibraryManagementSystemWithEF.DAL.EntityFramework;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void btnBorrowMenu_Click(object sender, EventArgs e)
        {
            BorrowBookMenu borrowBookMenu = new BorrowBookMenu();
            borrowBookMenu.Show();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            ReturnBookMenu returnBookMenu = new ReturnBookMenu();
            returnBookMenu.Show();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooksMenu manageBooksMenu = new ManageBooksMenu();
            manageBooksMenu.Show();
        }
    }
}
