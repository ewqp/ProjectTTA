namespace Library.GUI
{
    partial class AddBook
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelBookGenre = new System.Windows.Forms.Label();
            this.comboBoxBookGenre = new System.Windows.Forms.ComboBox();
            this.buttonSaveBook = new System.Windows.Forms.Button();
            this.buttonCancelSaveBook = new System.Windows.Forms.Button();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(26, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(94, 47);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(248, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(26, 82);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author:";
            // 
            // labelBookGenre
            // 
            this.labelBookGenre.AutoSize = true;
            this.labelBookGenre.Location = new System.Drawing.Point(26, 123);
            this.labelBookGenre.Name = "labelBookGenre";
            this.labelBookGenre.Size = new System.Drawing.Size(39, 13);
            this.labelBookGenre.TabIndex = 4;
            this.labelBookGenre.Text = "Genre:";
            // 
            // comboBoxBookGenre
            // 
            this.comboBoxBookGenre.DisplayMember = "IdType";
            this.comboBoxBookGenre.FormattingEnabled = true;
            this.comboBoxBookGenre.Location = new System.Drawing.Point(94, 123);
            this.comboBoxBookGenre.Name = "comboBoxBookGenre";
            this.comboBoxBookGenre.Size = new System.Drawing.Size(248, 21);
            this.comboBoxBookGenre.TabIndex = 5;
            this.comboBoxBookGenre.ValueMember = "IdType";
            // 
            // buttonSaveBook
            // 
            this.buttonSaveBook.Location = new System.Drawing.Point(94, 189);
            this.buttonSaveBook.Name = "buttonSaveBook";
            this.buttonSaveBook.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveBook.TabIndex = 6;
            this.buttonSaveBook.Text = "Save";
            this.buttonSaveBook.UseVisualStyleBackColor = true;
            this.buttonSaveBook.Click += new System.EventHandler(this.buttonSaveBook_Click);
            // 
            // buttonCancelSaveBook
            // 
            this.buttonCancelSaveBook.Location = new System.Drawing.Point(246, 189);
            this.buttonCancelSaveBook.Name = "buttonCancelSaveBook";
            this.buttonCancelSaveBook.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSaveBook.TabIndex = 7;
            this.buttonCancelSaveBook.Text = "Cancel";
            this.buttonCancelSaveBook.UseVisualStyleBackColor = true;
            this.buttonCancelSaveBook.Click += new System.EventHandler(this.buttonCancelSaveBook_Click);
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(94, 79);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(248, 21);
            this.comboBoxAuthor.TabIndex = 8;
            this.comboBoxAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAuthor_KeyPress);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 237);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.buttonCancelSaveBook);
            this.Controls.Add(this.buttonSaveBook);
            this.Controls.Add(this.comboBoxBookGenre);
            this.Controls.Add(this.labelBookGenre);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddBook";
            this.Text = "Add a new book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelBookGenre;
        private System.Windows.Forms.ComboBox comboBoxBookGenre;
        private System.Windows.Forms.Button buttonSaveBook;
        private System.Windows.Forms.Button buttonCancelSaveBook;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
    }
}