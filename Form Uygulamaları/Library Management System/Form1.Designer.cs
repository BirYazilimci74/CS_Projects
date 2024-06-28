namespace Library_Management_System
{
    partial class Form1
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
            this.header = new System.Windows.Forms.Label();
            this.btnBarrowBookMenu = new System.Windows.Forms.Button();
            this.btnReturnBookMenu = new System.Windows.Forms.Button();
            this.btnAddBookMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.header.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.header.Location = new System.Drawing.Point(54, 25);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(338, 29);
            this.header.TabIndex = 0;
            this.header.Text = "Library Management System";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBarrowBookMenu
            // 
            this.btnBarrowBookMenu.Location = new System.Drawing.Point(168, 150);
            this.btnBarrowBookMenu.Name = "btnBarrowBookMenu";
            this.btnBarrowBookMenu.Size = new System.Drawing.Size(135, 46);
            this.btnBarrowBookMenu.TabIndex = 1;
            this.btnBarrowBookMenu.Text = "Barrow Book";
            this.btnBarrowBookMenu.UseVisualStyleBackColor = true;
            this.btnBarrowBookMenu.Click += new System.EventHandler(this.btnBarrowBookMenu_Click);
            // 
            // btnReturnBookMenu
            // 
            this.btnReturnBookMenu.Location = new System.Drawing.Point(168, 225);
            this.btnReturnBookMenu.Name = "btnReturnBookMenu";
            this.btnReturnBookMenu.Size = new System.Drawing.Size(135, 46);
            this.btnReturnBookMenu.TabIndex = 2;
            this.btnReturnBookMenu.Text = "Return Book";
            this.btnReturnBookMenu.UseVisualStyleBackColor = true;
            this.btnReturnBookMenu.Click += new System.EventHandler(this.btnReturnBookMenu_Click);
            // 
            // btnAddBookMenu
            // 
            this.btnAddBookMenu.Location = new System.Drawing.Point(168, 300);
            this.btnAddBookMenu.Name = "btnAddBookMenu";
            this.btnAddBookMenu.Size = new System.Drawing.Size(135, 46);
            this.btnAddBookMenu.TabIndex = 3;
            this.btnAddBookMenu.Text = "Add Book";
            this.btnAddBookMenu.UseVisualStyleBackColor = true;
            this.btnAddBookMenu.Click += new System.EventHandler(this.btnAddBookMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 423);
            this.Controls.Add(this.btnAddBookMenu);
            this.Controls.Add(this.btnReturnBookMenu);
            this.Controls.Add(this.btnBarrowBookMenu);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button btnBarrowBookMenu;
        private System.Windows.Forms.Button btnReturnBookMenu;
        private System.Windows.Forms.Button btnAddBookMenu;
    }
}

