namespace LibraryManagementSystemWithEF
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
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbxSearchBookName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.AllowUserToAddRows = false;
            this.dgvBorrowedBooks.AllowUserToDeleteRows = false;
            this.dgvBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowedBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBorrowedBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvBorrowedBooks.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(100, 50);
            this.dgvBorrowedBooks.MultiSelect = false;
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.ReadOnly = true;
            this.dgvBorrowedBooks.RowHeadersWidth = 51;
            this.dgvBorrowedBooks.RowTemplate.Height = 24;
            this.dgvBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(800, 180);
            this.dgvBorrowedBooks.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(732, 257);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(122, 36);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbxSearchBookName
            // 
            this.tbxSearchBookName.Location = new System.Drawing.Point(100, 22);
            this.tbxSearchBookName.Name = "tbxSearchBookName";
            this.tbxSearchBookName.Size = new System.Drawing.Size(244, 22);
            this.tbxSearchBookName.TabIndex = 17;
            this.tbxSearchBookName.Text = "Book Name";
            this.tbxSearchBookName.TextChanged += new System.EventHandler(this.tbxSearchBookName_TextChanged);
            // 
            // ReturnBookMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tbxSearchBookName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvBorrowedBooks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBookMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBookMenu";
            this.Load += new System.EventHandler(this.ReturnBookMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbxSearchBookName;
    }
}