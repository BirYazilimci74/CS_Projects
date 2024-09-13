namespace LibraryManagementSystemWithAPI.UI
{
    partial class ReturnBookMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvBorrowedBooks = new DataGridView();
            tbxSearchBookName = new TextBox();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(196, 210, 245);
            label1.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 37);
            label1.MaximumSize = new Size(200, 80);
            label1.Name = "label1";
            label1.Size = new Size(78, 36);
            label1.TabIndex = 21;
            label1.Text = "Search";
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.AllowUserToAddRows = false;
            dgvBorrowedBooks.AllowUserToDeleteRows = false;
            dgvBorrowedBooks.AllowUserToOrderColumns = true;
            dgvBorrowedBooks.AllowUserToResizeColumns = false;
            dgvBorrowedBooks.AllowUserToResizeRows = false;
            dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowedBooks.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvBorrowedBooks.BorderStyle = BorderStyle.None;
            dgvBorrowedBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBorrowedBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Cursor = Cursors.Hand;
            dgvBorrowedBooks.EditMode = DataGridViewEditMode.EditOnF2;
            dgvBorrowedBooks.EnableHeadersVisualStyles = false;
            dgvBorrowedBooks.GridColor = SystemColors.ActiveCaptionText;
            dgvBorrowedBooks.Location = new Point(60, 80);
            dgvBorrowedBooks.MultiSelect = false;
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.ReadOnly = true;
            dgvBorrowedBooks.RowHeadersVisible = false;
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowedBooks.Size = new Size(800, 400);
            dgvBorrowedBooks.TabIndex = 20;
            // 
            // tbxSearchBookName
            // 
            tbxSearchBookName.Cursor = Cursors.IBeam;
            tbxSearchBookName.Location = new Point(180, 40);
            tbxSearchBookName.Name = "tbxSearchBookName";
            tbxSearchBookName.Size = new Size(603, 22);
            tbxSearchBookName.TabIndex = 17;
            tbxSearchBookName.Text = "Book Name";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.CornflowerBlue;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnReturn.Location = new Point(870, 90);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(100, 50);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // ReturnBookMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(982, 553);
            Controls.Add(btnReturn);
            Controls.Add(tbxSearchBookName);
            Controls.Add(dgvBorrowedBooks);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "ReturnBookMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBookMenu";
            Load += ReturnBookMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvBorrowedBooks;
        private TextBox tbxSearchBookName;
        private Button btnReturn;
    }
}