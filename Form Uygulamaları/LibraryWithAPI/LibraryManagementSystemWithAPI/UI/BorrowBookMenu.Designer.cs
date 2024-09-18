namespace LibraryManagementSystemWithAPI.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBookMenu));
            btnBorrow = new Button();
            tbxSearchBookName = new TextBox();
            dgvBooks = new DataGridView();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.CornflowerBlue;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnBorrow.Location = new Point(870, 90);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(100, 50);
            btnBorrow.TabIndex = 22;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // tbxSearchBookName
            // 
            tbxSearchBookName.BackColor = Color.White;
            tbxSearchBookName.BorderStyle = BorderStyle.None;
            tbxSearchBookName.Cursor = Cursors.IBeam;
            tbxSearchBookName.Location = new Point(3, 10);
            tbxSearchBookName.Name = "tbxSearchBookName";
            tbxSearchBookName.Size = new Size(350, 15);
            tbxSearchBookName.TabIndex = 23;
            tbxSearchBookName.Text = "Book Name";
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
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Cursor = Cursors.Hand;
            dgvBooks.EditMode = DataGridViewEditMode.EditOnF2;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = SystemColors.ActiveCaptionText;
            dgvBooks.Location = new Point(55, 76);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(800, 400);
            dgvBooks.TabIndex = 24;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(3, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 15);
            textBox1.TabIndex = 26;
            textBox1.Text = "Author";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(460, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 36);
            panel2.TabIndex = 30;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Dock = DockStyle.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(357, 0);
            button2.Name = "button2";
            button2.Size = new Size(36, 34);
            button2.TabIndex = 27;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tbxSearchBookName);
            panel1.Location = new Point(55, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 36);
            panel1.TabIndex = 29;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(357, 0);
            button1.Name = "button1";
            button1.Size = new Size(36, 34);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = false;
            // 
            // BorrowBookMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(982, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBorrow);
            Controls.Add(dgvBooks);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "BorrowBookMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowBookMenu";
            Load += BorrowBookMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrow;
        private TextBox tbxSearchBookName;
        private DataGridView dgvBooks;
        private TextBox textBox1;
        private Panel panel2;
        private Button button2;
        private Panel panel1;
        private Button button1;
    }
}