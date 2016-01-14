namespace Library.GUI
{
    partial class LibraryMenu
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.groupBoxDBOperation = new System.Windows.Forms.GroupBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.groupBoxGenre = new System.Windows.Forms.GroupBox();
            this.btnEditGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.groupBoxAuthor = new System.Windows.Forms.GroupBox();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.groupBoxBooks = new System.Windows.Forms.GroupBox();
            this.groupBoxLibraryOperation = new System.Windows.Forms.GroupBox();
            this.btnShowHist = new System.Windows.Forms.Button();
            this.btnBookReturn = new System.Windows.Forms.Button();
            this.btnBookRent = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHello = new System.Windows.Forms.Label();
            this.groupBoxDBOperation.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxGenre.SuspendLayout();
            this.groupBoxAuthor.SuspendLayout();
            this.groupBoxBooks.SuspendLayout();
            this.groupBoxLibraryOperation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddBook.Location = new System.Drawing.Point(3, 18);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(121, 23);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add books";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditBook.Location = new System.Drawing.Point(3, 41);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(121, 23);
            this.btnEditBook.TabIndex = 1;
            this.btnEditBook.Text = "Edit or delete books";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // groupBoxDBOperation
            // 
            this.groupBoxDBOperation.Controls.Add(this.groupBoxUser);
            this.groupBoxDBOperation.Controls.Add(this.groupBoxGenre);
            this.groupBoxDBOperation.Controls.Add(this.groupBoxAuthor);
            this.groupBoxDBOperation.Controls.Add(this.groupBoxBooks);
            this.groupBoxDBOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDBOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDBOperation.Location = new System.Drawing.Point(0, 50);
            this.groupBoxDBOperation.Name = "groupBoxDBOperation";
            this.groupBoxDBOperation.Size = new System.Drawing.Size(525, 130);
            this.groupBoxDBOperation.TabIndex = 2;
            this.groupBoxDBOperation.TabStop = false;
            this.groupBoxDBOperation.Text = "DB Operations";
            this.groupBoxDBOperation.Visible = false;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.btnEditUser);
            this.groupBoxUser.Controls.Add(this.btnAddUser);
            this.groupBoxUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxUser.Location = new System.Drawing.Point(375, 18);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(131, 109);
            this.groupBoxUser.TabIndex = 5;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "DB User";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditUser.Location = new System.Drawing.Point(3, 41);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(125, 23);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit or delete DB users";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddUser.Location = new System.Drawing.Point(3, 18);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(125, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add DB users";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // groupBoxGenre
            // 
            this.groupBoxGenre.Controls.Add(this.btnEditGenre);
            this.groupBoxGenre.Controls.Add(this.btnAddGenre);
            this.groupBoxGenre.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxGenre.Location = new System.Drawing.Point(252, 18);
            this.groupBoxGenre.Name = "groupBoxGenre";
            this.groupBoxGenre.Size = new System.Drawing.Size(123, 109);
            this.groupBoxGenre.TabIndex = 4;
            this.groupBoxGenre.TabStop = false;
            this.groupBoxGenre.Text = "Genre";
            // 
            // btnEditGenre
            // 
            this.btnEditGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditGenre.Location = new System.Drawing.Point(3, 41);
            this.btnEditGenre.Name = "btnEditGenre";
            this.btnEditGenre.Size = new System.Drawing.Size(117, 23);
            this.btnEditGenre.TabIndex = 1;
            this.btnEditGenre.Text = "Edit or delete genres";
            this.btnEditGenre.UseVisualStyleBackColor = true;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddGenre.Location = new System.Drawing.Point(3, 18);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(117, 23);
            this.btnAddGenre.TabIndex = 0;
            this.btnAddGenre.Text = "Add genres";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            // 
            // groupBoxAuthor
            // 
            this.groupBoxAuthor.Controls.Add(this.btnEditAuthor);
            this.groupBoxAuthor.Controls.Add(this.btnAddAuthor);
            this.groupBoxAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxAuthor.Location = new System.Drawing.Point(130, 18);
            this.groupBoxAuthor.Name = "groupBoxAuthor";
            this.groupBoxAuthor.Size = new System.Drawing.Size(122, 109);
            this.groupBoxAuthor.TabIndex = 3;
            this.groupBoxAuthor.TabStop = false;
            this.groupBoxAuthor.Text = "Author";
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditAuthor.Location = new System.Drawing.Point(3, 41);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(116, 23);
            this.btnEditAuthor.TabIndex = 1;
            this.btnEditAuthor.Text = "Edit or delete authors";
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddAuthor.Location = new System.Drawing.Point(3, 18);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(116, 23);
            this.btnAddAuthor.TabIndex = 0;
            this.btnAddAuthor.Text = "Add authors";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            // 
            // groupBoxBooks
            // 
            this.groupBoxBooks.Controls.Add(this.btnEditBook);
            this.groupBoxBooks.Controls.Add(this.btnAddBook);
            this.groupBoxBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxBooks.Location = new System.Drawing.Point(3, 18);
            this.groupBoxBooks.Name = "groupBoxBooks";
            this.groupBoxBooks.Size = new System.Drawing.Size(127, 109);
            this.groupBoxBooks.TabIndex = 2;
            this.groupBoxBooks.TabStop = false;
            this.groupBoxBooks.Text = "Book";
            // 
            // groupBoxLibraryOperation
            // 
            this.groupBoxLibraryOperation.Controls.Add(this.btnShowHist);
            this.groupBoxLibraryOperation.Controls.Add(this.btnBookReturn);
            this.groupBoxLibraryOperation.Controls.Add(this.btnBookRent);
            this.groupBoxLibraryOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLibraryOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxLibraryOperation.Location = new System.Drawing.Point(0, 180);
            this.groupBoxLibraryOperation.Name = "groupBoxLibraryOperation";
            this.groupBoxLibraryOperation.Size = new System.Drawing.Size(525, 178);
            this.groupBoxLibraryOperation.TabIndex = 3;
            this.groupBoxLibraryOperation.TabStop = false;
            this.groupBoxLibraryOperation.Text = "Library Operations";
            // 
            // btnShowHist
            // 
            this.btnShowHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowHist.Location = new System.Drawing.Point(3, 105);
            this.btnShowHist.Name = "btnShowHist";
            this.btnShowHist.Size = new System.Drawing.Size(519, 47);
            this.btnShowHist.TabIndex = 2;
            this.btnShowHist.Text = "Show History";
            this.btnShowHist.UseVisualStyleBackColor = true;
            // 
            // btnBookReturn
            // 
            this.btnBookReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookReturn.Location = new System.Drawing.Point(3, 62);
            this.btnBookReturn.Name = "btnBookReturn";
            this.btnBookReturn.Size = new System.Drawing.Size(519, 43);
            this.btnBookReturn.TabIndex = 1;
            this.btnBookReturn.Text = "Return books";
            this.btnBookReturn.UseVisualStyleBackColor = true;
            // 
            // btnBookRent
            // 
            this.btnBookRent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookRent.Location = new System.Drawing.Point(3, 18);
            this.btnBookRent.Name = "btnBookRent";
            this.btnBookRent.Size = new System.Drawing.Size(519, 44);
            this.btnBookRent.TabIndex = 0;
            this.btnBookRent.Text = "Rent books";
            this.btnBookRent.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(447, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 25);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHello);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 50);
            this.panel1.TabIndex = 3;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHello.Location = new System.Drawing.Point(478, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(47, 15);
            this.lblHello.TabIndex = 3;
            this.lblHello.Text = "label1";
            // 
            // LibraryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 358);
            this.Controls.Add(this.groupBoxLibraryOperation);
            this.Controls.Add(this.groupBoxDBOperation);
            this.Controls.Add(this.panel1);
            this.Name = "LibraryMenu";
            this.Text = "Menu of Library";
            this.groupBoxDBOperation.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxGenre.ResumeLayout(false);
            this.groupBoxAuthor.ResumeLayout(false);
            this.groupBoxBooks.ResumeLayout(false);
            this.groupBoxLibraryOperation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.GroupBox groupBoxDBOperation;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox groupBoxGenre;
        private System.Windows.Forms.Button btnEditGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.GroupBox groupBoxAuthor;
        private System.Windows.Forms.Button btnEditAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.GroupBox groupBoxBooks;
        private System.Windows.Forms.GroupBox groupBoxLibraryOperation;
        private System.Windows.Forms.Button btnBookReturn;
        private System.Windows.Forms.Button btnBookRent;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnShowHist;
    }
}