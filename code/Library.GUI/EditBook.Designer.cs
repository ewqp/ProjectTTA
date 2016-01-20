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
            this.dataGridSearchBook = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchBook)).BeginInit();
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelSaveBook
            // 
            this.buttonCancelSaveBook.Location = new System.Drawing.Point(266, 188);
            this.buttonCancelSaveBook.Name = "buttonCancelSaveBook";
            this.buttonCancelSaveBook.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSaveBook.TabIndex = 15;
            this.buttonCancelSaveBook.Text = "Cancel";
            this.buttonCancelSaveBook.UseVisualStyleBackColor = true;
            this.buttonCancelSaveBook.Click += new System.EventHandler(this.buttonCancelSaveBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(49, 188);
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
            this.comboBoxBookGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxBookGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxBookGenre.FormattingEnabled = true;
            this.comboBoxBookGenre.Location = new System.Drawing.Point(3, 103);
            this.comboBoxBookGenre.Name = "comboBoxBookGenre";
            this.comboBoxBookGenre.Size = new System.Drawing.Size(360, 21);
            this.comboBoxBookGenre.TabIndex = 13;
            this.comboBoxBookGenre.ValueMember = "IdType";
            // 
            // labelBookGenre
            // 
            this.labelBookGenre.AutoSize = true;
            this.labelBookGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBookGenre.Location = new System.Drawing.Point(3, 88);
            this.labelBookGenre.Name = "labelBookGenre";
            this.labelBookGenre.Size = new System.Drawing.Size(50, 15);
            this.labelBookGenre.TabIndex = 12;
            this.labelBookGenre.Text = "Genre:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAuthor.Location = new System.Drawing.Point(3, 52);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(52, 15);
            this.labelAuthor.TabIndex = 10;
            this.labelAuthor.Text = "Author:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTitle.Location = new System.Drawing.Point(3, 32);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(360, 20);
            this.textBoxTitle.TabIndex = 9;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(3, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 15);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearch.Location = new System.Drawing.Point(3, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(366, 20);
            this.textBoxSearch.TabIndex = 17;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridSearchBook
            // 
            this.dataGridSearchBook.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.Genre});
            this.dataGridSearchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSearchBook.Location = new System.Drawing.Point(3, 16);
            this.dataGridSearchBook.Name = "dataGridSearchBook";
            this.dataGridSearchBook.Size = new System.Drawing.Size(474, 326);
            this.dataGridSearchBook.TabIndex = 20;
            this.dataGridSearchBook.Click += new System.EventHandler(this.dataGridSearchBook_Click);
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
            this.buttonDeleteBook.Location = new System.Drawing.Point(162, 188);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteBook.TabIndex = 21;
            this.buttonDeleteBook.Text = "Delete";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(3, 67);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(360, 21);
            this.comboBoxAuthor.TabIndex = 22;
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.groupBoxEdit);
            this.groupBoxLeft.Controls.Add(this.textBoxSearch);
            this.groupBoxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(372, 345);
            this.groupBoxLeft.TabIndex = 23;
            this.groupBoxLeft.TabStop = false;
            this.groupBoxLeft.Text = "Search:";
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.comboBoxBookGenre);
            this.groupBoxEdit.Controls.Add(this.labelBookGenre);
            this.groupBoxEdit.Controls.Add(this.comboBoxAuthor);
            this.groupBoxEdit.Controls.Add(this.labelAuthor);
            this.groupBoxEdit.Controls.Add(this.textBoxTitle);
            this.groupBoxEdit.Controls.Add(this.labelTitle);
            this.groupBoxEdit.Controls.Add(this.buttonCancelSaveBook);
            this.groupBoxEdit.Controls.Add(this.btnUpdateBook);
            this.groupBoxEdit.Controls.Add(this.buttonDeleteBook);
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEdit.Location = new System.Drawing.Point(3, 93);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(366, 249);
            this.groupBoxEdit.TabIndex = 23;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit:";
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.dataGridSearchBook);
            this.groupBoxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxRight.Location = new System.Drawing.Point(378, 0);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(480, 345);
            this.groupBoxRight.TabIndex = 24;
            this.groupBoxRight.TabStop = false;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 345);
            this.Controls.Add(this.groupBoxRight);
            this.Controls.Add(this.groupBoxLeft);
            this.Name = "EditBook";
            this.Text = "Edit an existing book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchBook)).EndInit();
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxLeft.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxRight.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridSearchBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.GroupBox groupBoxEdit;
    }
}