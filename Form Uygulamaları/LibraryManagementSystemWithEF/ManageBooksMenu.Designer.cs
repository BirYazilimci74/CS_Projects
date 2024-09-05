namespace LibraryManagementSystemWithEF
{
    partial class ManageBooksMenu
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
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.numAddStock = new System.Windows.Forms.NumericUpDown();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.tbxAddAuthor = new System.Windows.Forms.TextBox();
            this.tbxAddName = new System.Windows.Forms.TextBox();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.numUpdateStock = new System.Windows.Forms.NumericUpDown();
            this.cmbUpdateCategory = new System.Windows.Forms.ComboBox();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.lblUpdateAuthor = new System.Windows.Forms.Label();
            this.tbxUpdateAuthor = new System.Windows.Forms.TextBox();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxSearchBookName = new System.Windows.Forms.TextBox();
            this.tbxSearchAuthor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddStock)).BeginInit();
            this.gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.numAddStock);
            this.gbAdd.Controls.Add(this.cmbAddCategory);
            this.gbAdd.Controls.Add(this.lblAddCategory);
            this.gbAdd.Controls.Add(this.tbxAddAuthor);
            this.gbAdd.Controls.Add(this.tbxAddName);
            this.gbAdd.Controls.Add(this.lblAddStock);
            this.gbAdd.Controls.Add(this.lblAddAuthor);
            this.gbAdd.Controls.Add(this.lblAddName);
            this.gbAdd.Location = new System.Drawing.Point(37, 270);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(415, 225);
            this.gbAdd.TabIndex = 4;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Book";
            // 
            // numAddStock
            // 
            this.numAddStock.Location = new System.Drawing.Point(120, 173);
            this.numAddStock.Name = "numAddStock";
            this.numAddStock.Size = new System.Drawing.Size(178, 22);
            this.numAddStock.TabIndex = 7;
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(120, 130);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(178, 24);
            this.cmbAddCategory.TabIndex = 3;
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddCategory.Location = new System.Drawing.Point(26, 130);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(88, 22);
            this.lblAddCategory.TabIndex = 6;
            this.lblAddCategory.Text = "Category:";
            // 
            // tbxAddAuthor
            // 
            this.tbxAddAuthor.Location = new System.Drawing.Point(120, 90);
            this.tbxAddAuthor.Name = "tbxAddAuthor";
            this.tbxAddAuthor.Size = new System.Drawing.Size(178, 22);
            this.tbxAddAuthor.TabIndex = 2;
            // 
            // tbxAddName
            // 
            this.tbxAddName.Location = new System.Drawing.Point(120, 50);
            this.tbxAddName.Name = "tbxAddName";
            this.tbxAddName.Size = new System.Drawing.Size(178, 22);
            this.tbxAddName.TabIndex = 1;
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddStock.Location = new System.Drawing.Point(26, 170);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(60, 22);
            this.lblAddStock.TabIndex = 2;
            this.lblAddStock.Text = "Stock:";
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddAuthor.Location = new System.Drawing.Point(26, 90);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(68, 22);
            this.lblAddAuthor.TabIndex = 1;
            this.lblAddAuthor.Text = "Author:";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddName.Location = new System.Drawing.Point(26, 50);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(62, 22);
            this.lblAddName.TabIndex = 0;
            this.lblAddName.Text = "Name:";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.numUpdateStock);
            this.gbUpdate.Controls.Add(this.cmbUpdateCategory);
            this.gbUpdate.Controls.Add(this.tbxUpdateName);
            this.gbUpdate.Controls.Add(this.lblUpdateCategory);
            this.gbUpdate.Controls.Add(this.lblUpdateName);
            this.gbUpdate.Controls.Add(this.lblUpdateAuthor);
            this.gbUpdate.Controls.Add(this.tbxUpdateAuthor);
            this.gbUpdate.Controls.Add(this.lblUpdateStock);
            this.gbUpdate.Location = new System.Drawing.Point(520, 270);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(415, 225);
            this.gbUpdate.TabIndex = 5;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update Book";
            // 
            // numUpdateStock
            // 
            this.numUpdateStock.Location = new System.Drawing.Point(134, 175);
            this.numUpdateStock.Name = "numUpdateStock";
            this.numUpdateStock.Size = new System.Drawing.Size(178, 22);
            this.numUpdateStock.TabIndex = 8;
            // 
            // cmbUpdateCategory
            // 
            this.cmbUpdateCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateCategory.FormattingEnabled = true;
            this.cmbUpdateCategory.Location = new System.Drawing.Point(134, 132);
            this.cmbUpdateCategory.Name = "cmbUpdateCategory";
            this.cmbUpdateCategory.Size = new System.Drawing.Size(178, 24);
            this.cmbUpdateCategory.TabIndex = 8;
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(134, 52);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(178, 22);
            this.tbxUpdateName.TabIndex = 6;
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateCategory.Location = new System.Drawing.Point(40, 132);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(88, 22);
            this.lblUpdateCategory.TabIndex = 14;
            this.lblUpdateCategory.Text = "Category:";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateName.Location = new System.Drawing.Point(40, 52);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(62, 22);
            this.lblUpdateName.TabIndex = 8;
            this.lblUpdateName.Text = "Name:";
            // 
            // lblUpdateAuthor
            // 
            this.lblUpdateAuthor.AutoSize = true;
            this.lblUpdateAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateAuthor.Location = new System.Drawing.Point(40, 92);
            this.lblUpdateAuthor.Name = "lblUpdateAuthor";
            this.lblUpdateAuthor.Size = new System.Drawing.Size(68, 22);
            this.lblUpdateAuthor.TabIndex = 9;
            this.lblUpdateAuthor.Text = "Author:";
            // 
            // tbxUpdateAuthor
            // 
            this.tbxUpdateAuthor.Location = new System.Drawing.Point(134, 92);
            this.tbxUpdateAuthor.Name = "tbxUpdateAuthor";
            this.tbxUpdateAuthor.Size = new System.Drawing.Size(178, 22);
            this.tbxUpdateAuthor.TabIndex = 7;
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateStock.Location = new System.Drawing.Point(40, 172);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(60, 22);
            this.lblUpdateStock.TabIndex = 10;
            this.lblUpdateStock.Text = "Stock:";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(339, 501);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(113, 26);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(822, 501);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(113, 26);
            this.btnUpdateBook.TabIndex = 10;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(787, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 26);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxSearchBookName
            // 
            this.tbxSearchBookName.Location = new System.Drawing.Point(100, 22);
            this.tbxSearchBookName.Name = "tbxSearchBookName";
            this.tbxSearchBookName.Size = new System.Drawing.Size(244, 22);
            this.tbxSearchBookName.TabIndex = 8;
            this.tbxSearchBookName.Text = "Book Name";
            this.tbxSearchBookName.TextChanged += new System.EventHandler(this.tbxSearchBookName_TextChanged);
            // 
            // tbxSearchAuthor
            // 
            this.tbxSearchAuthor.Location = new System.Drawing.Point(376, 22);
            this.tbxSearchAuthor.Name = "tbxSearchAuthor";
            this.tbxSearchAuthor.Size = new System.Drawing.Size(244, 22);
            this.tbxSearchAuthor.TabIndex = 16;
            this.tbxSearchAuthor.Text = "Author";
            this.tbxSearchAuthor.TextChanged += new System.EventHandler(this.tbxSearchAuthor_TextChanged);
            // 
            // ManageBooksMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tbxSearchAuthor);
            this.Controls.Add(this.tbxSearchBookName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.dgvBooks);
            this.Name = "ManageBooksMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooksMenu";
            this.Load += new System.EventHandler(this.ManageBooksMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddStock)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox tbxAddAuthor;
        private System.Windows.Forms.TextBox tbxAddName;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.ComboBox cmbAddCategory;
        private System.Windows.Forms.ComboBox cmbUpdateCategory;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Label lblUpdateAuthor;
        private System.Windows.Forms.TextBox tbxUpdateAuthor;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown numAddStock;
        private System.Windows.Forms.NumericUpDown numUpdateStock;
        private System.Windows.Forms.TextBox tbxSearchBookName;
        private System.Windows.Forms.TextBox tbxSearchAuthor;
    }
}