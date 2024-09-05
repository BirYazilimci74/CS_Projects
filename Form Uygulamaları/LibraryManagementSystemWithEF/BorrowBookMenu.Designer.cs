namespace LibraryManagementSystemWithEF
{
    partial class BorrowBookMenu
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.tbxSearchAuthor = new System.Windows.Forms.TextBox();
            this.tbxSearchBookName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvBooks.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBooks.Location = new System.Drawing.Point(100, 50);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(800, 180);
            this.dgvBooks.TabIndex = 2;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(787, 236);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(113, 26);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // tbxSearchAuthor
            // 
            this.tbxSearchAuthor.Location = new System.Drawing.Point(377, 22);
            this.tbxSearchAuthor.Name = "tbxSearchAuthor";
            this.tbxSearchAuthor.Size = new System.Drawing.Size(244, 22);
            this.tbxSearchAuthor.TabIndex = 18;
            this.tbxSearchAuthor.Text = "Author";
            this.tbxSearchAuthor.TextChanged += new System.EventHandler(this.tbxSearchAuthor_TextChanged);
            // 
            // tbxSearchBookName
            // 
            this.tbxSearchBookName.Location = new System.Drawing.Point(101, 22);
            this.tbxSearchBookName.Name = "tbxSearchBookName";
            this.tbxSearchBookName.Size = new System.Drawing.Size(244, 22);
            this.tbxSearchBookName.TabIndex = 17;
            this.tbxSearchBookName.Text = "Book Name";
            this.tbxSearchBookName.TextChanged += new System.EventHandler(this.tbxSearchBookName_TextChanged);
            // 
            // BorrowBookMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tbxSearchAuthor);
            this.Controls.Add(this.tbxSearchBookName);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dgvBooks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BorrowBookMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBookMenu";
            this.Load += new System.EventHandler(this.BorrowBookMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox tbxSearchAuthor;
        private System.Windows.Forms.TextBox tbxSearchBookName;
    }
}