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
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.groupBoxDown = new System.Windows.Forms.GroupBox();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBoxTop.SuspendLayout();
            this.groupBoxDown.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Location = new System.Drawing.Point(3, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTitle.Location = new System.Drawing.Point(3, 32);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(585, 21);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAuthor.Location = new System.Drawing.Point(3, 53);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(52, 15);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author:";
            // 
            // labelBookGenre
            // 
            this.labelBookGenre.AutoSize = true;
            this.labelBookGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBookGenre.Location = new System.Drawing.Point(3, 91);
            this.labelBookGenre.Name = "labelBookGenre";
            this.labelBookGenre.Size = new System.Drawing.Size(50, 15);
            this.labelBookGenre.TabIndex = 4;
            this.labelBookGenre.Text = "Genre:";
            // 
            // comboBoxBookGenre
            // 
            this.comboBoxBookGenre.DisplayMember = "IdType";
            this.comboBoxBookGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxBookGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxBookGenre.FormattingEnabled = true;
            this.comboBoxBookGenre.Location = new System.Drawing.Point(3, 106);
            this.comboBoxBookGenre.Name = "comboBoxBookGenre";
            this.comboBoxBookGenre.Size = new System.Drawing.Size(585, 23);
            this.comboBoxBookGenre.TabIndex = 5;
            this.comboBoxBookGenre.ValueMember = "IdType";
            this.comboBoxBookGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxBookGenre_KeyPress);
            // 
            // buttonSaveBook
            // 
            this.buttonSaveBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSaveBook.Location = new System.Drawing.Point(3, 17);
            this.buttonSaveBook.Name = "buttonSaveBook";
            this.buttonSaveBook.Size = new System.Drawing.Size(75, 29);
            this.buttonSaveBook.TabIndex = 6;
            this.buttonSaveBook.Text = "Save";
            this.buttonSaveBook.UseVisualStyleBackColor = true;
            this.buttonSaveBook.Click += new System.EventHandler(this.buttonSaveBook_Click);
            // 
            // buttonCancelSaveBook
            // 
            this.buttonCancelSaveBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancelSaveBook.Location = new System.Drawing.Point(513, 17);
            this.buttonCancelSaveBook.Name = "buttonCancelSaveBook";
            this.buttonCancelSaveBook.Size = new System.Drawing.Size(75, 29);
            this.buttonCancelSaveBook.TabIndex = 7;
            this.buttonCancelSaveBook.Text = "Cancel";
            this.buttonCancelSaveBook.UseVisualStyleBackColor = true;
            this.buttonCancelSaveBook.Click += new System.EventHandler(this.buttonCancelSaveBook_Click);
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(3, 68);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(585, 23);
            this.comboBoxAuthor.TabIndex = 8;
            this.comboBoxAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAuthor_KeyPress);
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.comboBoxBookGenre);
            this.groupBoxTop.Controls.Add(this.labelBookGenre);
            this.groupBoxTop.Controls.Add(this.comboBoxAuthor);
            this.groupBoxTop.Controls.Add(this.labelAuthor);
            this.groupBoxTop.Controls.Add(this.textBoxTitle);
            this.groupBoxTop.Controls.Add(this.labelTitle);
            this.groupBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxTop.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(591, 178);
            this.groupBoxTop.TabIndex = 9;
            this.groupBoxTop.TabStop = false;
            // 
            // groupBoxDown
            // 
            this.groupBoxDown.Controls.Add(this.buttonCancelSaveBook);
            this.groupBoxDown.Controls.Add(this.buttonSaveBook);
            this.groupBoxDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDown.Location = new System.Drawing.Point(0, 181);
            this.groupBoxDown.Name = "groupBoxDown";
            this.groupBoxDown.Size = new System.Drawing.Size(591, 49);
            this.groupBoxDown.TabIndex = 10;
            this.groupBoxDown.TabStop = false;
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.lblMsg);
            this.groupBoxMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxMsg.Location = new System.Drawing.Point(0, 230);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(591, 39);
            this.groupBoxMsg.TabIndex = 9;
            this.groupBoxMsg.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(3, 17);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 15);
            this.lblMsg.TabIndex = 0;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 269);
            this.Controls.Add(this.groupBoxDown);
            this.Controls.Add(this.groupBoxTop);
            this.Controls.Add(this.groupBoxMsg);
            this.Name = "AddBook";
            this.Text = "Add a new book";
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.groupBoxDown.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBoxMsg.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.GroupBox groupBoxDown;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Label lblMsg;
    }
}