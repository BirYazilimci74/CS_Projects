namespace LibraryManagementSystemWithAPI.UI
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
            tbxSearchBookName = new TextBox();
            tbxSearchAuthor = new TextBox();
            tbxAddName = new TextBox();
            tbxAddAuthor = new TextBox();
            dgvBooks = new DataGridView();
            btnDelete = new Button();
            cmbAddCatagory = new ComboBox();
            numAddStock = new NumericUpDown();
            gbAdd = new GroupBox();
            lblAddCatagory = new Label();
            lblAddAuthor = new Label();
            lblAddStock = new Label();
            lblAddName = new Label();
            label1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            numeUpdateStock = new NumericUpDown();
            gbUpdate = new GroupBox();
            lblUpdateCatagory = new Label();
            lblUpdateAuthor = new Label();
            lblUpdateStock = new Label();
            lblUpdateName = new Label();
            tbxUpdateName = new TextBox();
            tbxUpdateAuthor = new TextBox();
            numUpdateStock = new NumericUpDown();
            cbxUpdateCatagory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAddStock).BeginInit();
            gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeUpdateStock).BeginInit();
            gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpdateStock).BeginInit();
            SuspendLayout();
            // 
            // tbxSearchBookName
            // 
            tbxSearchBookName.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxSearchBookName.Location = new Point(240, 16);
            tbxSearchBookName.Name = "tbxSearchBookName";
            tbxSearchBookName.Size = new Size(300, 22);
            tbxSearchBookName.TabIndex = 8;
            tbxSearchBookName.Text = "Book Name";
            // 
            // tbxSearchAuthor
            // 
            tbxSearchAuthor.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxSearchAuthor.Location = new Point(560, 16);
            tbxSearchAuthor.Name = "tbxSearchAuthor";
            tbxSearchAuthor.Size = new Size(300, 22);
            tbxSearchAuthor.TabIndex = 16;
            tbxSearchAuthor.Text = "Author";
            // 
            // tbxAddName
            // 
            tbxAddName.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxAddName.Location = new Point(120, 50);
            tbxAddName.Name = "tbxAddName";
            tbxAddName.Size = new Size(178, 22);
            tbxAddName.TabIndex = 4;
            // 
            // tbxAddAuthor
            // 
            tbxAddAuthor.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxAddAuthor.Location = new Point(120, 90);
            tbxAddAuthor.Name = "tbxAddAuthor";
            tbxAddAuthor.Size = new Size(178, 22);
            tbxAddAuthor.TabIndex = 5;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AllowUserToOrderColumns = true;
            dgvBooks.AllowUserToResizeColumns = false;
            dgvBooks.AllowUserToResizeRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Cursor = Cursors.Hand;
            dgvBooks.EditMode = DataGridViewEditMode.EditOnF2;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = SystemColors.ActiveCaptionText;
            dgvBooks.Location = new Point(100, 50);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(800, 180);
            dgvBooks.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.CornflowerBlue;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Myanmar Text", 7.8F, FontStyle.Bold);
            btnDelete.Location = new Point(787, 236);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 35);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // cmbAddCatagory
            // 
            cmbAddCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddCatagory.DropDownWidth = 178;
            cmbAddCatagory.Font = new Font("Microsoft Sans Serif", 7.8F);
            cmbAddCatagory.FormattingEnabled = true;
            cmbAddCatagory.Location = new Point(120, 130);
            cmbAddCatagory.Name = "cmbAddCatagory";
            cmbAddCatagory.Size = new Size(178, 24);
            cmbAddCatagory.TabIndex = 3;
            // 
            // numAddStock
            // 
            numAddStock.Font = new Font("Microsoft Sans Serif", 7.8F);
            numAddStock.Location = new Point(120, 170);
            numAddStock.Name = "numAddStock";
            numAddStock.Size = new Size(178, 22);
            numAddStock.TabIndex = 7;
            // 
            // gbAdd
            // 
            gbAdd.Controls.Add(lblAddCatagory);
            gbAdd.Controls.Add(lblAddAuthor);
            gbAdd.Controls.Add(lblAddStock);
            gbAdd.Controls.Add(lblAddName);
            gbAdd.Controls.Add(tbxAddName);
            gbAdd.Controls.Add(tbxAddAuthor);
            gbAdd.Controls.Add(numAddStock);
            gbAdd.Controls.Add(cmbAddCatagory);
            gbAdd.Location = new Point(37, 273);
            gbAdd.Name = "gbAdd";
            gbAdd.Size = new Size(415, 225);
            gbAdd.TabIndex = 14;
            gbAdd.TabStop = false;
            gbAdd.Text = "Add Book";
            // 
            // lblAddCatagory
            // 
            lblAddCatagory.AutoSize = true;
            lblAddCatagory.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblAddCatagory.Location = new Point(26, 130);
            lblAddCatagory.Name = "lblAddCatagory";
            lblAddCatagory.Size = new Size(88, 22);
            lblAddCatagory.TabIndex = 17;
            lblAddCatagory.Text = "Catagory:";
            // 
            // lblAddAuthor
            // 
            lblAddAuthor.AutoSize = true;
            lblAddAuthor.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblAddAuthor.Location = new Point(26, 90);
            lblAddAuthor.Name = "lblAddAuthor";
            lblAddAuthor.Size = new Size(63, 22);
            lblAddAuthor.TabIndex = 16;
            lblAddAuthor.Text = "Author";
            // 
            // lblAddStock
            // 
            lblAddStock.AutoSize = true;
            lblAddStock.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblAddStock.Location = new Point(26, 170);
            lblAddStock.Name = "lblAddStock";
            lblAddStock.Size = new Size(60, 22);
            lblAddStock.TabIndex = 15;
            lblAddStock.Text = "Stock:";
            // 
            // lblAddName
            // 
            lblAddName.AutoSize = true;
            lblAddName.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblAddName.Location = new Point(26, 50);
            lblAddName.Name = "lblAddName";
            lblAddName.Size = new Size(62, 22);
            lblAddName.TabIndex = 0;
            lblAddName.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            label1.Location = new Point(130, 11);
            label1.Name = "label1";
            label1.Size = new Size(78, 36);
            label1.TabIndex = 21;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Myanmar Text", 7.8F, FontStyle.Bold);
            btnAdd.Location = new Point(340, 503);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 35);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Myanmar Text", 7.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(820, 503);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 35);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // numeUpdateStock
            // 
            numeUpdateStock.Location = new Point(0, 0);
            numeUpdateStock.Name = "numeUpdateStock";
            numeUpdateStock.Size = new Size(120, 27);
            numeUpdateStock.TabIndex = 0;
            // 
            // gbUpdate
            // 
            gbUpdate.Controls.Add(lblUpdateCatagory);
            gbUpdate.Controls.Add(lblUpdateAuthor);
            gbUpdate.Controls.Add(lblUpdateStock);
            gbUpdate.Controls.Add(lblUpdateName);
            gbUpdate.Controls.Add(tbxUpdateName);
            gbUpdate.Controls.Add(tbxUpdateAuthor);
            gbUpdate.Controls.Add(numUpdateStock);
            gbUpdate.Controls.Add(cbxUpdateCatagory);
            gbUpdate.Location = new Point(518, 273);
            gbUpdate.Name = "gbUpdate";
            gbUpdate.Size = new Size(415, 225);
            gbUpdate.TabIndex = 18;
            gbUpdate.TabStop = false;
            gbUpdate.Text = "Update Book";
            // 
            // lblUpdateCatagory
            // 
            lblUpdateCatagory.AutoSize = true;
            lblUpdateCatagory.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblUpdateCatagory.Location = new Point(26, 130);
            lblUpdateCatagory.Name = "lblUpdateCatagory";
            lblUpdateCatagory.Size = new Size(88, 22);
            lblUpdateCatagory.TabIndex = 17;
            lblUpdateCatagory.Text = "Catagory:";
            // 
            // lblUpdateAuthor
            // 
            lblUpdateAuthor.AutoSize = true;
            lblUpdateAuthor.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblUpdateAuthor.Location = new Point(26, 90);
            lblUpdateAuthor.Name = "lblUpdateAuthor";
            lblUpdateAuthor.Size = new Size(63, 22);
            lblUpdateAuthor.TabIndex = 16;
            lblUpdateAuthor.Text = "Author";
            // 
            // lblUpdateStock
            // 
            lblUpdateStock.AutoSize = true;
            lblUpdateStock.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblUpdateStock.Location = new Point(26, 174);
            lblUpdateStock.Name = "lblUpdateStock";
            lblUpdateStock.Size = new Size(60, 22);
            lblUpdateStock.TabIndex = 15;
            lblUpdateStock.Text = "Stock:";
            // 
            // lblUpdateName
            // 
            lblUpdateName.AutoSize = true;
            lblUpdateName.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblUpdateName.Location = new Point(26, 50);
            lblUpdateName.Name = "lblUpdateName";
            lblUpdateName.Size = new Size(62, 22);
            lblUpdateName.TabIndex = 0;
            lblUpdateName.Text = "Name:";
            // 
            // tbxUpdateName
            // 
            tbxUpdateName.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxUpdateName.Location = new Point(120, 50);
            tbxUpdateName.Name = "tbxUpdateName";
            tbxUpdateName.Size = new Size(178, 22);
            tbxUpdateName.TabIndex = 4;
            // 
            // tbxUpdateAuthor
            // 
            tbxUpdateAuthor.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxUpdateAuthor.Location = new Point(120, 90);
            tbxUpdateAuthor.Name = "tbxUpdateAuthor";
            tbxUpdateAuthor.Size = new Size(178, 22);
            tbxUpdateAuthor.TabIndex = 5;
            // 
            // numUpdateStock
            // 
            numUpdateStock.Font = new Font("Microsoft Sans Serif", 7.8F);
            numUpdateStock.Location = new Point(120, 170);
            numUpdateStock.Name = "numUpdateStock";
            numUpdateStock.Size = new Size(178, 22);
            numUpdateStock.TabIndex = 7;
            // 
            // cbxUpdateCatagory
            // 
            cbxUpdateCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUpdateCatagory.DropDownWidth = 178;
            cbxUpdateCatagory.Font = new Font("Microsoft Sans Serif", 7.8F);
            cbxUpdateCatagory.FormattingEnabled = true;
            cbxUpdateCatagory.Location = new Point(120, 130);
            cbxUpdateCatagory.Name = "cbxUpdateCatagory";
            cbxUpdateCatagory.Size = new Size(178, 24);
            cbxUpdateCatagory.TabIndex = 3;
            // 
            // ManageBooksMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(982, 553);
            Controls.Add(gbUpdate);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(gbAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvBooks);
            Controls.Add(tbxSearchAuthor);
            Controls.Add(tbxSearchBookName);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ManageBooksMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageBooksMenu";
            Load += ManageBooksMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAddStock).EndInit();
            gbAdd.ResumeLayout(false);
            gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeUpdateStock).EndInit();
            gbUpdate.ResumeLayout(false);
            gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpdateStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxSearchBookName;
        private TextBox tbxSearchAuthor;
        private TextBox tbxAddName;
        private TextBox tbxAddAuthor;
        private DataGridView dgvBooks;
        private Button btnDelete;
        private ComboBox cmbAddCatagory;
        private NumericUpDown numAddStock;
        private GroupBox gbAdd;
        private Label lblAddName;
        private Label label1;
        private Label lblAddStock;
        private Label lblUpdateAuthor;
        private Label lblUpdateCatagory;
        private Button btnAdd;
        private Button btnUpdate;
        private GroupBox gbUpdate;
        private Label lblUpdateName;
        private NumericUpDown numeUpdateStock;
        private Label lblAddCatagory;
        private Label lblAddAuthor;
        private Label lblUpdateStock;
        private TextBox tbxUpdateName;
        private TextBox tbxUpdateAuthor;
        private NumericUpDown numUpdateStock;
        private ComboBox cbxUpdateCatagory;
    }
}