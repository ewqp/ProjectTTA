namespace Library.GUI
{
    partial class ReturnBook
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
            this.groupBoxRentedBooks = new System.Windows.Forms.GroupBox();
            this.dataGridRentedBooks = new System.Windows.Forms.DataGridView();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.lblSearchRent = new System.Windows.Forms.Label();
            this.textBoxSearchRent = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxRentedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedBooks)).BeginInit();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRentedBooks
            // 
            this.groupBoxRentedBooks.Controls.Add(this.dataGridRentedBooks);
            this.groupBoxRentedBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRentedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxRentedBooks.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRentedBooks.Name = "groupBoxRentedBooks";
            this.groupBoxRentedBooks.Size = new System.Drawing.Size(539, 157);
            this.groupBoxRentedBooks.TabIndex = 0;
            this.groupBoxRentedBooks.TabStop = false;
            this.groupBoxRentedBooks.Text = "Currently rented books:";
            // 
            // dataGridRentedBooks
            // 
            this.dataGridRentedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRentedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.account,
            this.title,
            this.author,
            this.rentDate});
            this.dataGridRentedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRentedBooks.Location = new System.Drawing.Point(3, 17);
            this.dataGridRentedBooks.Name = "dataGridRentedBooks";
            this.dataGridRentedBooks.Size = new System.Drawing.Size(533, 137);
            this.dataGridRentedBooks.TabIndex = 0;
            this.dataGridRentedBooks.Click += new System.EventHandler(this.dataGridRentedBooks_Click);
            // 
            // account
            // 
            this.account.HeaderText = "Account";
            this.account.Name = "account";
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
            // rentDate
            // 
            this.rentDate.HeaderText = "Rent date";
            this.rentDate.Name = "rentDate";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnClose);
            this.groupBoxActions.Controls.Add(this.btnReturn);
            this.groupBoxActions.Controls.Add(this.textBoxSearchRent);
            this.groupBoxActions.Controls.Add(this.lblSearchRent);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxActions.Location = new System.Drawing.Point(0, 157);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(539, 146);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            // 
            // lblSearchRent
            // 
            this.lblSearchRent.AutoSize = true;
            this.lblSearchRent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchRent.Location = new System.Drawing.Point(3, 17);
            this.lblSearchRent.Name = "lblSearchRent";
            this.lblSearchRent.Size = new System.Drawing.Size(80, 15);
            this.lblSearchRent.TabIndex = 0;
            this.lblSearchRent.Text = "Find an entry:";
            // 
            // textBoxSearchRent
            // 
            this.textBoxSearchRent.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchRent.Location = new System.Drawing.Point(3, 32);
            this.textBoxSearchRent.Name = "textBoxSearchRent";
            this.textBoxSearchRent.Size = new System.Drawing.Size(533, 21);
            this.textBoxSearchRent.TabIndex = 1;
            this.textBoxSearchRent.TextChanged += new System.EventHandler(this.textBoxSearchRent_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(97, 93);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(310, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 315);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxRentedBooks);
            this.Name = "ReturnBook";
            this.Text = "Return books";
            this.groupBoxRentedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedBooks)).EndInit();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRentedBooks;
        private System.Windows.Forms.DataGridView dataGridRentedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDate;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.TextBox textBoxSearchRent;
        private System.Windows.Forms.Label lblSearchRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClose;
    }
}