namespace Library.GUI
{
    partial class EditAuthor
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
            this.dataGridSearchAuthor = new System.Windows.Forms.DataGridView();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonUpdateAuthor = new System.Windows.Forms.Button();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.buttonCancelAuthor = new System.Windows.Forms.Button();
            this.labelNameAuthor = new System.Windows.Forms.Label();
            this.labelSurnameAuthor = new System.Windows.Forms.Label();
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.groupBoxAuthSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxAuthEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxAuthBtn = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAuthor)).BeginInit();
            this.groupBoxRight.SuspendLayout();
            this.groupBoxAuthSearch.SuspendLayout();
            this.groupBoxAuthEdit.SuspendLayout();
            this.groupBoxAuthBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSearchAuthor
            // 
            this.dataGridSearchAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surname,
            this.name});
            this.dataGridSearchAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSearchAuthor.Location = new System.Drawing.Point(3, 16);
            this.dataGridSearchAuthor.Name = "dataGridSearchAuthor";
            this.dataGridSearchAuthor.Size = new System.Drawing.Size(438, 326);
            this.dataGridSearchAuthor.TabIndex = 0;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // textBoxSearchAuthor
            // 
            this.textBoxSearchAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchAuthor.Location = new System.Drawing.Point(3, 17);
            this.textBoxSearchAuthor.Name = "textBoxSearchAuthor";
            this.textBoxSearchAuthor.Size = new System.Drawing.Size(408, 20);
            this.textBoxSearchAuthor.TabIndex = 1;
            this.textBoxSearchAuthor.TextChanged += new System.EventHandler(this.textBoxSearchAuthor_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(3, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(408, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSurname.Location = new System.Drawing.Point(3, 67);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(408, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // buttonUpdateAuthor
            // 
            this.buttonUpdateAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUpdateAuthor.Location = new System.Drawing.Point(3, 17);
            this.buttonUpdateAuthor.Name = "buttonUpdateAuthor";
            this.buttonUpdateAuthor.Size = new System.Drawing.Size(75, 45);
            this.buttonUpdateAuthor.TabIndex = 4;
            this.buttonUpdateAuthor.Text = "Update";
            this.buttonUpdateAuthor.UseVisualStyleBackColor = true;
            this.buttonUpdateAuthor.Click += new System.EventHandler(this.buttonUpdateAuthor_Click);
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(78, 17);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(75, 45);
            this.buttonDeleteAuthor.TabIndex = 5;
            this.buttonDeleteAuthor.Text = "Delete";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.buttonDeleteAuthor_Click);
            // 
            // buttonCancelAuthor
            // 
            this.buttonCancelAuthor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancelAuthor.Location = new System.Drawing.Point(336, 17);
            this.buttonCancelAuthor.Name = "buttonCancelAuthor";
            this.buttonCancelAuthor.Size = new System.Drawing.Size(75, 45);
            this.buttonCancelAuthor.TabIndex = 6;
            this.buttonCancelAuthor.Text = "Cancel";
            this.buttonCancelAuthor.UseVisualStyleBackColor = true;
            this.buttonCancelAuthor.Click += new System.EventHandler(this.buttonCancelAuthor_Click);
            // 
            // labelNameAuthor
            // 
            this.labelNameAuthor.AutoSize = true;
            this.labelNameAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNameAuthor.Location = new System.Drawing.Point(3, 17);
            this.labelNameAuthor.Name = "labelNameAuthor";
            this.labelNameAuthor.Size = new System.Drawing.Size(49, 15);
            this.labelNameAuthor.TabIndex = 8;
            this.labelNameAuthor.Text = "Name:";
            // 
            // labelSurnameAuthor
            // 
            this.labelSurnameAuthor.AutoSize = true;
            this.labelSurnameAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSurnameAuthor.Location = new System.Drawing.Point(3, 52);
            this.labelSurnameAuthor.Name = "labelSurnameAuthor";
            this.labelSurnameAuthor.Size = new System.Drawing.Size(69, 15);
            this.labelSurnameAuthor.TabIndex = 9;
            this.labelSurnameAuthor.Text = "Surname:";
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.dataGridSearchAuthor);
            this.groupBoxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxRight.Location = new System.Drawing.Point(414, 0);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(444, 345);
            this.groupBoxRight.TabIndex = 11;
            this.groupBoxRight.TabStop = false;
            // 
            // groupBoxAuthSearch
            // 
            this.groupBoxAuthSearch.Controls.Add(this.textBoxSearchAuthor);
            this.groupBoxAuthSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAuthSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxAuthSearch.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAuthSearch.Name = "groupBoxAuthSearch";
            this.groupBoxAuthSearch.Size = new System.Drawing.Size(414, 81);
            this.groupBoxAuthSearch.TabIndex = 12;
            this.groupBoxAuthSearch.TabStop = false;
            this.groupBoxAuthSearch.Text = "Search:";
            // 
            // groupBoxAuthEdit
            // 
            this.groupBoxAuthEdit.Controls.Add(this.textBoxSurname);
            this.groupBoxAuthEdit.Controls.Add(this.labelSurnameAuthor);
            this.groupBoxAuthEdit.Controls.Add(this.textBoxName);
            this.groupBoxAuthEdit.Controls.Add(this.labelNameAuthor);
            this.groupBoxAuthEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAuthEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxAuthEdit.Location = new System.Drawing.Point(0, 81);
            this.groupBoxAuthEdit.Name = "groupBoxAuthEdit";
            this.groupBoxAuthEdit.Size = new System.Drawing.Size(414, 193);
            this.groupBoxAuthEdit.TabIndex = 13;
            this.groupBoxAuthEdit.TabStop = false;
            this.groupBoxAuthEdit.Text = "Edit:";
            // 
            // groupBoxAuthBtn
            // 
            this.groupBoxAuthBtn.Controls.Add(this.buttonCancelAuthor);
            this.groupBoxAuthBtn.Controls.Add(this.buttonDeleteAuthor);
            this.groupBoxAuthBtn.Controls.Add(this.buttonUpdateAuthor);
            this.groupBoxAuthBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAuthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxAuthBtn.Location = new System.Drawing.Point(0, 280);
            this.groupBoxAuthBtn.Name = "groupBoxAuthBtn";
            this.groupBoxAuthBtn.Size = new System.Drawing.Size(414, 65);
            this.groupBoxAuthBtn.TabIndex = 10;
            this.groupBoxAuthBtn.TabStop = false;
            // 
            // EditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 345);
            this.Controls.Add(this.groupBoxAuthBtn);
            this.Controls.Add(this.groupBoxAuthEdit);
            this.Controls.Add(this.groupBoxAuthSearch);
            this.Controls.Add(this.groupBoxRight);
            this.Name = "EditAuthor";
            this.Text = "Edit authors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAuthor)).EndInit();
            this.groupBoxRight.ResumeLayout(false);
            this.groupBoxAuthSearch.ResumeLayout(false);
            this.groupBoxAuthSearch.PerformLayout();
            this.groupBoxAuthEdit.ResumeLayout(false);
            this.groupBoxAuthEdit.PerformLayout();
            this.groupBoxAuthBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSearchAuthor;
        private System.Windows.Forms.TextBox textBoxSearchAuthor;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button buttonUpdateAuthor;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.Button buttonCancelAuthor;
        private System.Windows.Forms.Label labelNameAuthor;
        private System.Windows.Forms.Label labelSurnameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.GroupBox groupBoxAuthSearch;
        private System.Windows.Forms.GroupBox groupBoxAuthEdit;
        private System.Windows.Forms.GroupBox groupBoxAuthBtn;
    }
}