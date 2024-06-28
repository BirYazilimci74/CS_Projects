namespace Library_Management_System
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSearchBorrowed = new System.Windows.Forms.TextBox();
            this.btnSearchMyBook = new System.Windows.Forms.Button();
            this.txtReturnError = new System.Windows.Forms.Label();
            this.listViewLibrary = new System.Windows.Forms.ListView();
            this.lTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number_Of_Copy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Borrowed_Copy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBorrow = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorrowedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOverDue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Image = global::Library_Management_System.Properties.Resources.search2;
            this.btnSearch.Location = new System.Drawing.Point(1125, 91);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturn.Location = new System.Drawing.Point(437, 531);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(173, 69);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(489, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 45);
            this.label4.TabIndex = 23;
            this.label4.Text = "Return Menu";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(678, 95);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(442, 28);
            this.txtSearch.TabIndex = 29;
            // 
            // txtSearchBorrowed
            // 
            this.txtSearchBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBorrowed.Location = new System.Drawing.Point(24, 95);
            this.txtSearchBorrowed.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBorrowed.Name = "txtSearchBorrowed";
            this.txtSearchBorrowed.Size = new System.Drawing.Size(434, 28);
            this.txtSearchBorrowed.TabIndex = 32;
            // 
            // btnSearchMyBook
            // 
            this.btnSearchMyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchMyBook.Image = global::Library_Management_System.Properties.Resources.search2;
            this.btnSearchMyBook.Location = new System.Drawing.Point(580, 92);
            this.btnSearchMyBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchMyBook.Name = "btnSearchMyBook";
            this.btnSearchMyBook.Size = new System.Drawing.Size(30, 30);
            this.btnSearchMyBook.TabIndex = 31;
            this.btnSearchMyBook.UseVisualStyleBackColor = true;
            this.btnSearchMyBook.Click += new System.EventHandler(this.btnSearchMyBook_Click);
            // 
            // txtReturnError
            // 
            this.txtReturnError.AutoSize = true;
            this.txtReturnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReturnError.ForeColor = System.Drawing.Color.Red;
            this.txtReturnError.Location = new System.Drawing.Point(24, 511);
            this.txtReturnError.Name = "txtReturnError";
            this.txtReturnError.Size = new System.Drawing.Size(0, 16);
            this.txtReturnError.TabIndex = 33;
            // 
            // listViewLibrary
            // 
            this.listViewLibrary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lTitle,
            this.Author,
            this.ISBN,
            this.Number_Of_Copy,
            this.Borrowed_Copy});
            this.listViewLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewLibrary.FullRowSelect = true;
            this.listViewLibrary.GridLines = true;
            this.listViewLibrary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewLibrary.HideSelection = false;
            this.listViewLibrary.Location = new System.Drawing.Point(678, 135);
            this.listViewLibrary.Name = "listViewLibrary";
            this.listViewLibrary.Size = new System.Drawing.Size(477, 374);
            this.listViewLibrary.TabIndex = 40;
            this.listViewLibrary.UseCompatibleStateImageBehavior = false;
            this.listViewLibrary.View = System.Windows.Forms.View.Details;
            // 
            // lTitle
            // 
            this.lTitle.Text = "Title";
            this.lTitle.Width = 95;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 95;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 90;
            // 
            // Number_Of_Copy
            // 
            this.Number_Of_Copy.Text = "Copy";
            this.Number_Of_Copy.Width = 55;
            // 
            // Borrowed_Copy
            // 
            this.Borrowed_Copy.Text = "Borrowed Copy";
            this.Borrowed_Copy.Width = 136;
            // 
            // listViewBorrow
            // 
            this.listViewBorrow.AllowDrop = true;
            this.listViewBorrow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.bAuthor,
            this.bISBN,
            this.BorrowedTime,
            this.ReturnTime});
            this.listViewBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewBorrow.FullRowSelect = true;
            this.listViewBorrow.GridLines = true;
            this.listViewBorrow.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBorrow.HideSelection = false;
            this.listViewBorrow.Location = new System.Drawing.Point(24, 135);
            this.listViewBorrow.MultiSelect = false;
            this.listViewBorrow.Name = "listViewBorrow";
            this.listViewBorrow.Size = new System.Drawing.Size(586, 374);
            this.listViewBorrow.TabIndex = 41;
            this.listViewBorrow.UseCompatibleStateImageBehavior = false;
            this.listViewBorrow.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 110;
            // 
            // bAuthor
            // 
            this.bAuthor.Text = "Author";
            this.bAuthor.Width = 110;
            // 
            // bISBN
            // 
            this.bISBN.Text = "ISBN";
            this.bISBN.Width = 100;
            // 
            // BorrowedTime
            // 
            this.BorrowedTime.Text = "Borrow Time";
            this.BorrowedTime.Width = 130;
            // 
            // ReturnTime
            // 
            this.ReturnTime.Text = "Return Time";
            this.ReturnTime.Width = 130;
            // 
            // btnOverDue
            // 
            this.btnOverDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOverDue.Location = new System.Drawing.Point(462, 92);
            this.btnOverDue.Margin = new System.Windows.Forms.Padding(4);
            this.btnOverDue.Name = "btnOverDue";
            this.btnOverDue.Size = new System.Drawing.Size(117, 30);
            this.btnOverDue.TabIndex = 42;
            this.btnOverDue.Text = "List Overdue";
            this.btnOverDue.UseVisualStyleBackColor = true;
            this.btnOverDue.Click += new System.EventHandler(this.btnOverDue_Click);
            // 
            // ReturnBookMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.btnOverDue);
            this.Controls.Add(this.listViewBorrow);
            this.Controls.Add(this.listViewLibrary);
            this.Controls.Add(this.txtReturnError);
            this.Controls.Add(this.txtSearchBorrowed);
            this.Controls.Add(this.btnSearchMyBook);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReturnBookMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBookMenu";
            this.Load += new System.EventHandler(this.ReturnBookMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtSearchBorrowed;
        private System.Windows.Forms.Button btnSearchMyBook;
        private System.Windows.Forms.Label txtReturnError;
        private System.Windows.Forms.ListView listViewLibrary;
        private System.Windows.Forms.ColumnHeader lTitle;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader Number_Of_Copy;
        private System.Windows.Forms.ColumnHeader Borrowed_Copy;
        private System.Windows.Forms.ListView listViewBorrow;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader bAuthor;
        private System.Windows.Forms.ColumnHeader bISBN;
        private System.Windows.Forms.ColumnHeader BorrowedTime;
        private System.Windows.Forms.ColumnHeader ReturnTime;
        private System.Windows.Forms.Button btnOverDue;
    }
}