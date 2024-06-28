namespace Library_Management_System
{
    partial class AddBookMenu
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mskTxtISBN = new System.Windows.Forms.MaskedTextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.txtNumberOfCopy = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTitleError = new System.Windows.Forms.Label();
            this.txtAuthorError = new System.Windows.Forms.Label();
            this.txtISBNerror = new System.Windows.Forms.Label();
            this.txtNOCerror = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number_Of_Copy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Borrowed_Copy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(383, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 45);
            this.label4.TabIndex = 22;
            this.label4.Text = "Add Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(202, 406);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 69);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mskTxtISBN
            // 
            this.mskTxtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTxtISBN.Location = new System.Drawing.Point(250, 270);
            this.mskTxtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.mskTxtISBN.Mask = "0000000000000";
            this.mskTxtISBN.Name = "mskTxtISBN";
            this.mskTxtISBN.Size = new System.Drawing.Size(125, 26);
            this.mskTxtISBN.TabIndex = 19;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookAuthor.Location = new System.Drawing.Point(250, 210);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(125, 26);
            this.txtBookAuthor.TabIndex = 18;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookTitle.Location = new System.Drawing.Point(250, 150);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(125, 26);
            this.txtBookTitle.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Number Of Copy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "ISBN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Author:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Title.Location = new System.Drawing.Point(50, 150);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(61, 25);
            this.Title.TabIndex = 12;
            this.Title.Text = "Title:";
            // 
            // txtNumberOfCopy
            // 
            this.txtNumberOfCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfCopy.Location = new System.Drawing.Point(250, 330);
            this.txtNumberOfCopy.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfCopy.Name = "txtNumberOfCopy";
            this.txtNumberOfCopy.Size = new System.Drawing.Size(125, 26);
            this.txtNumberOfCopy.TabIndex = 24;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(447, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(380, 26);
            this.txtSearch.TabIndex = 28;
            // 
            // txtTitleError
            // 
            this.txtTitleError.AutoSize = true;
            this.txtTitleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitleError.ForeColor = System.Drawing.Color.Red;
            this.txtTitleError.Location = new System.Drawing.Point(247, 180);
            this.txtTitleError.Name = "txtTitleError";
            this.txtTitleError.Size = new System.Drawing.Size(0, 16);
            this.txtTitleError.TabIndex = 29;
            // 
            // txtAuthorError
            // 
            this.txtAuthorError.AutoSize = true;
            this.txtAuthorError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAuthorError.ForeColor = System.Drawing.Color.Red;
            this.txtAuthorError.Location = new System.Drawing.Point(247, 240);
            this.txtAuthorError.Name = "txtAuthorError";
            this.txtAuthorError.Size = new System.Drawing.Size(0, 16);
            this.txtAuthorError.TabIndex = 30;
            // 
            // txtISBNerror
            // 
            this.txtISBNerror.AutoSize = true;
            this.txtISBNerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtISBNerror.ForeColor = System.Drawing.Color.Red;
            this.txtISBNerror.Location = new System.Drawing.Point(247, 300);
            this.txtISBNerror.Name = "txtISBNerror";
            this.txtISBNerror.Size = new System.Drawing.Size(0, 16);
            this.txtISBNerror.TabIndex = 31;
            // 
            // txtNOCerror
            // 
            this.txtNOCerror.AutoSize = true;
            this.txtNOCerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNOCerror.ForeColor = System.Drawing.Color.Red;
            this.txtNOCerror.Location = new System.Drawing.Point(247, 360);
            this.txtNOCerror.Name = "txtNOCerror";
            this.txtNOCerror.Size = new System.Drawing.Size(0, 16);
            this.txtNOCerror.TabIndex = 32;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Author,
            this.ISBN,
            this.Number_Of_Copy,
            this.Borrowed_Copy});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(447, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(415, 448);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 82;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 82;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 82;
            // 
            // Number_Of_Copy
            // 
            this.Number_Of_Copy.Text = "Number Of Copy";
            this.Number_Of_Copy.Width = 82;
            // 
            // Borrowed_Copy
            // 
            this.Borrowed_Copy.Text = "Borrowed Copy";
            this.Borrowed_Copy.Width = 82;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Image = global::Library_Management_System.Properties.Resources.search2;
            this.btnSearch.Location = new System.Drawing.Point(832, 90);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AddBookMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtNOCerror);
            this.Controls.Add(this.txtISBNerror);
            this.Controls.Add(this.txtAuthorError);
            this.Controls.Add(this.txtTitleError);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtNumberOfCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mskTxtISBN);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddBookMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBookMenu";
            this.Load += new System.EventHandler(this.AddBookMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mskTxtISBN;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtNumberOfCopy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label txtTitleError;
        private System.Windows.Forms.Label txtAuthorError;
        private System.Windows.Forms.Label txtISBNerror;
        private System.Windows.Forms.Label txtNOCerror;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader Number_Of_Copy;
        private System.Windows.Forms.ColumnHeader Borrowed_Copy;
    }
}