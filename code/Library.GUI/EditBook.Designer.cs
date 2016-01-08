namespace Library.GUI
{
    partial class EditBook
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
            this.buttonCancelSaveBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.comboBoxBookGenre = new System.Windows.Forms.ComboBox();
            this.labelBookGenre = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridSearchBook = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchBook)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelSaveBook
            // 
            this.buttonCancelSaveBook.Location = new System.Drawing.Point(314, 282);
            this.buttonCancelSaveBook.Name = "buttonCancelSaveBook";
            this.buttonCancelSaveBook.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSaveBook.TabIndex = 15;
            this.buttonCancelSaveBook.Text = "Cancel";
            this.buttonCancelSaveBook.UseVisualStyleBackColor = true;
            this.buttonCancelSaveBook.Click += new System.EventHandler(this.buttonCancelSaveBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(97, 282);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBook.TabIndex = 14;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // comboBoxBookGenre
            // 
            this.comboBoxBookGenre.DisplayMember = "IdType";
            this.comboBoxBookGenre.FormattingEnabled = true;
            this.comboBoxBookGenre.Location = new System.Drawing.Point(141, 216);
            this.comboBoxBookGenre.Name = "comboBoxBookGenre";
            this.comboBoxBookGenre.Size = new System.Drawing.Size(248, 21);
            this.comboBoxBookGenre.TabIndex = 13;
            this.comboBoxBookGenre.ValueMember = "IdType";
            // 
            // labelBookGenre
            // 
            this.labelBookGenre.AutoSize = true;
            this.labelBookGenre.Location = new System.Drawing.Point(73, 216);
            this.labelBookGenre.Name = "labelBookGenre";
            this.labelBookGenre.Size = new System.Drawing.Size(39, 13);
            this.labelBookGenre.TabIndex = 12;
            this.labelBookGenre.Text = "Genre:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(73, 175);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 10;
            this.labelAuthor.Text = "Author:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(141, 140);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(248, 20);
            this.textBoxTitle.TabIndex = 9;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(73, 140);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(141, 60);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(248, 20);
            this.textBoxSearch.TabIndex = 17;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Location = new System.Drawing.Point(239, 111);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(28, 13);
            this.labelEdit.TabIndex = 19;
            this.labelEdit.Text = "Edit:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(73, 63);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 18;
            this.labelSearch.Text = "Search:";
            // 
            // dataGridSearchBook
            // 
            this.dataGridSearchBook.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.Genre});
            this.dataGridSearchBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridSearchBook.Location = new System.Drawing.Point(431, 0);
            this.dataGridSearchBook.Name = "dataGridSearchBook";
            this.dataGridSearchBook.Size = new System.Drawing.Size(427, 345);
            this.dataGridSearchBook.TabIndex = 20;
            this.dataGridSearchBook.SelectionChanged += new System.EventHandler(this.dataGridSearchBook_SelectionChanged);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(210, 282);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteBook.TabIndex = 21;
            this.buttonDeleteBook.Text = "Delete";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(141, 172);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(248, 21);
            this.comboBoxAuthor.TabIndex = 22;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 345);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.dataGridSearchBook);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonCancelSaveBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.comboBoxBookGenre);
            this.Controls.Add(this.labelBookGenre);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditBook";
            this.Text = "Edit an existing book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelSaveBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.ComboBox comboBoxBookGenre;
        private System.Windows.Forms.Label labelBookGenre;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridSearchBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
    }
}