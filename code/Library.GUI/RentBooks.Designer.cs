namespace Library.GUI
{
    partial class RentBooks
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
            this.dataGridRent = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBooks = new System.Windows.Forms.Label();
            this.groupBoxBooks = new System.Windows.Forms.GroupBox();
            this.txtBoxBook = new System.Windows.Forms.TextBox();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.dataGridAccounts = new System.Windows.Forms.DataGridView();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxBtn = new System.Windows.Forms.GroupBox();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRent)).BeginInit();
            this.groupBoxBooks.SuspendLayout();
            this.groupBoxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).BeginInit();
            this.groupBoxBtn.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRent
            // 
            this.dataGridRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.author,
            this.genre});
            this.dataGridRent.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridRent.Location = new System.Drawing.Point(0, 183);
            this.dataGridRent.Name = "dataGridRent";
            this.dataGridRent.Size = new System.Drawing.Size(602, 94);
            this.dataGridRent.TabIndex = 0;
            this.dataGridRent.Click += new System.EventHandler(this.dataGridRent_Click);
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBooks.Location = new System.Drawing.Point(3, 17);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(66, 13);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "Find a book:";
            // 
            // groupBoxBooks
            // 
            this.groupBoxBooks.Controls.Add(this.txtBoxBook);
            this.groupBoxBooks.Controls.Add(this.lblBooks);
            this.groupBoxBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBooks.Location = new System.Drawing.Point(0, 139);
            this.groupBoxBooks.Name = "groupBoxBooks";
            this.groupBoxBooks.Size = new System.Drawing.Size(602, 44);
            this.groupBoxBooks.TabIndex = 2;
            this.groupBoxBooks.TabStop = false;
            this.groupBoxBooks.Text = "Choose books";
            // 
            // txtBoxBook
            // 
            this.txtBoxBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBoxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxBook.Location = new System.Drawing.Point(69, 17);
            this.txtBoxBook.Name = "txtBoxBook";
            this.txtBoxBook.Size = new System.Drawing.Size(516, 20);
            this.txtBoxBook.TabIndex = 2;
            this.txtBoxBook.TextChanged += new System.EventHandler(this.txtBoxBook_TextChanged);
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.textBoxAccount);
            this.groupBoxUsers.Controls.Add(this.lblAccount);
            this.groupBoxUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxUsers.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Size = new System.Drawing.Size(602, 49);
            this.groupBoxUsers.TabIndex = 3;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Choose a client";
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAccount.Location = new System.Drawing.Point(61, 17);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(529, 20);
            this.textBoxAccount.TabIndex = 1;
            this.textBoxAccount.TextChanged += new System.EventHandler(this.textBoxAccount_TextChanged);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAccount.Location = new System.Drawing.Point(3, 17);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(58, 13);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Find client:";
            // 
            // dataGridAccounts
            // 
            this.dataGridAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountName,
            this.accountEmail});
            this.dataGridAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridAccounts.Location = new System.Drawing.Point(0, 49);
            this.dataGridAccounts.Name = "dataGridAccounts";
            this.dataGridAccounts.Size = new System.Drawing.Size(602, 90);
            this.dataGridAccounts.TabIndex = 4;
            this.dataGridAccounts.Click += new System.EventHandler(this.dataGridAccounts_Click);
            // 
            // accountName
            // 
            this.accountName.HeaderText = "Account";
            this.accountName.Name = "accountName";
            // 
            // accountEmail
            // 
            this.accountEmail.HeaderText = "Email";
            this.accountEmail.Name = "accountEmail";
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(3, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Rent";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(524, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBoxBtn
            // 
            this.groupBoxBtn.Controls.Add(this.btnClose);
            this.groupBoxBtn.Controls.Add(this.btnAdd);
            this.groupBoxBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBtn.Location = new System.Drawing.Point(0, 299);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(602, 48);
            this.groupBoxBtn.TabIndex = 7;
            this.groupBoxBtn.TabStop = false;
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.lblMsg);
            this.groupBoxMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxMsg.Location = new System.Drawing.Point(0, 347);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(602, 35);
            this.groupBoxMsg.TabIndex = 8;
            this.groupBoxMsg.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(3, 16);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 15);
            this.lblMsg.TabIndex = 0;
            // 
            // RentBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 382);
            this.Controls.Add(this.groupBoxBtn);
            this.Controls.Add(this.groupBoxMsg);
            this.Controls.Add(this.dataGridRent);
            this.Controls.Add(this.groupBoxBooks);
            this.Controls.Add(this.dataGridAccounts);
            this.Controls.Add(this.groupBoxUsers);
            this.Name = "RentBooks";
            this.Text = "Rent books";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRent)).EndInit();
            this.groupBoxBooks.ResumeLayout(false);
            this.groupBoxBooks.PerformLayout();
            this.groupBoxUsers.ResumeLayout(false);
            this.groupBoxUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).EndInit();
            this.groupBoxBtn.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBoxMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.GroupBox groupBoxBooks;
        private System.Windows.Forms.TextBox txtBoxBook;
        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.DataGridView dataGridAccounts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountEmail;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Label lblMsg;
    }
}