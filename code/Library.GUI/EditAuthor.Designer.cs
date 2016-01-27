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
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonUpdateAuthor = new System.Windows.Forms.Button();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.buttonCancelAuthor = new System.Windows.Forms.Button();
            this.labelNameAuthor = new System.Windows.Forms.Label();
            this.labelSurnameAuthor = new System.Windows.Forms.Label();
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.groupBoxBtn = new System.Windows.Forms.GroupBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAuthor)).BeginInit();
            this.groupBoxRight.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxBtn.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSearchAuthor
            // 
            this.dataGridSearchAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname});
            this.dataGridSearchAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSearchAuthor.Location = new System.Drawing.Point(3, 16);
            this.dataGridSearchAuthor.Name = "dataGridSearchAuthor";
            this.dataGridSearchAuthor.Size = new System.Drawing.Size(370, 353);
            this.dataGridSearchAuthor.TabIndex = 0;
            this.dataGridSearchAuthor.Click += new System.EventHandler(this.dataGridSearchAuthor_Click);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // textBoxSearchAuthor
            // 
            this.textBoxSearchAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchAuthor.Location = new System.Drawing.Point(3, 17);
            this.textBoxSearchAuthor.Name = "textBoxSearchAuthor";
            this.textBoxSearchAuthor.Size = new System.Drawing.Size(357, 21);
            this.textBoxSearchAuthor.TabIndex = 1;
            this.textBoxSearchAuthor.TextChanged += new System.EventHandler(this.textBoxSearchAuthor_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(3, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(357, 21);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSurname.Location = new System.Drawing.Point(3, 68);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(357, 21);
            this.textBoxSurname.TabIndex = 3;
            // 
            // buttonUpdateAuthor
            // 
            this.buttonUpdateAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUpdateAuthor.Location = new System.Drawing.Point(3, 17);
            this.buttonUpdateAuthor.Name = "buttonUpdateAuthor";
            this.buttonUpdateAuthor.Size = new System.Drawing.Size(75, 50);
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
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(75, 50);
            this.buttonDeleteAuthor.TabIndex = 5;
            this.buttonDeleteAuthor.Text = "Delete";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.buttonDeleteAuthor_Click);
            // 
            // buttonCancelAuthor
            // 
            this.buttonCancelAuthor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancelAuthor.Location = new System.Drawing.Point(285, 17);
            this.buttonCancelAuthor.Name = "buttonCancelAuthor";
            this.buttonCancelAuthor.Size = new System.Drawing.Size(75, 50);
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
            this.labelSurnameAuthor.Location = new System.Drawing.Point(3, 53);
            this.labelSurnameAuthor.Name = "labelSurnameAuthor";
            this.labelSurnameAuthor.Size = new System.Drawing.Size(69, 15);
            this.labelSurnameAuthor.TabIndex = 9;
            this.labelSurnameAuthor.Text = "Surname:";
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.dataGridSearchAuthor);
            this.groupBoxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxRight.Location = new System.Drawing.Point(392, 0);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(376, 372);
            this.groupBoxRight.TabIndex = 11;
            this.groupBoxRight.TabStop = false;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearchAuthor);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSearch.Location = new System.Drawing.Point(3, 16);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(363, 69);
            this.groupBoxSearch.TabIndex = 12;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search:";
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.groupBoxBtn);
            this.groupBoxLeft.Controls.Add(this.groupBoxEdit);
            this.groupBoxLeft.Controls.Add(this.groupBoxSearch);
            this.groupBoxLeft.Controls.Add(this.groupBoxMsg);
            this.groupBoxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(369, 372);
            this.groupBoxLeft.TabIndex = 13;
            this.groupBoxLeft.TabStop = false;
            // 
            // groupBoxBtn
            // 
            this.groupBoxBtn.Controls.Add(this.buttonDeleteAuthor);
            this.groupBoxBtn.Controls.Add(this.buttonUpdateAuthor);
            this.groupBoxBtn.Controls.Add(this.buttonCancelAuthor);
            this.groupBoxBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBtn.Location = new System.Drawing.Point(3, 262);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(363, 70);
            this.groupBoxBtn.TabIndex = 14;
            this.groupBoxBtn.TabStop = false;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.textBoxSurname);
            this.groupBoxEdit.Controls.Add(this.labelSurnameAuthor);
            this.groupBoxEdit.Controls.Add(this.textBoxName);
            this.groupBoxEdit.Controls.Add(this.labelNameAuthor);
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEdit.Location = new System.Drawing.Point(3, 85);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(363, 125);
            this.groupBoxEdit.TabIndex = 13;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit:";
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.lblMsg);
            this.groupBoxMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxMsg.Location = new System.Drawing.Point(3, 332);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(363, 37);
            this.groupBoxMsg.TabIndex = 1;
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
            // EditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 372);
            this.Controls.Add(this.groupBoxLeft);
            this.Controls.Add(this.groupBoxRight);
            this.Name = "EditAuthor";
            this.Text = "Edit authors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAuthor)).EndInit();
            this.groupBoxRight.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxBtn.ResumeLayout(false);
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBoxMsg.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Label lblMsg;
    }
}