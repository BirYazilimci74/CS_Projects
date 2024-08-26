namespace LibraryManagementSystemWithEF
{
    partial class Library
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
            this.btnBorrowMenu = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorrowMenu
            // 
            this.btnBorrowMenu.Location = new System.Drawing.Point(195, 100);
            this.btnBorrowMenu.Name = "btnBorrowMenu";
            this.btnBorrowMenu.Size = new System.Drawing.Size(160, 80);
            this.btnBorrowMenu.TabIndex = 0;
            this.btnBorrowMenu.Text = "Borrow";
            this.btnBorrowMenu.UseVisualStyleBackColor = true;
            this.btnBorrowMenu.Click += new System.EventHandler(this.btnBorrowMenu_Click);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Location = new System.Drawing.Point(195, 200);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(160, 80);
            this.btnReturnMenu.TabIndex = 1;
            this.btnReturnMenu.Text = "Return";
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(195, 300);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(160, 80);
            this.btnManageBooks.TabIndex = 2;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.btnBorrowMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBorrowMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnManageBooks;
    }
}

