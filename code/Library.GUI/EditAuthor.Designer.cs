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
            this.textBoxSearchAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonUpdateAuthor = new System.Windows.Forms.Button();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.buttonCancelAuthor = new System.Windows.Forms.Button();
            this.labelSearchAuthor = new System.Windows.Forms.Label();
            this.labelNameAuthor = new System.Windows.Forms.Label();
            this.labelSurnameAuthor = new System.Windows.Forms.Label();
            this.labelEditAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSearchAuthor
            // 
            this.dataGridSearchAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchAuthor.Location = new System.Drawing.Point(431, 0);
            this.dataGridSearchAuthor.Name = "dataGridSearchAuthor";
            this.dataGridSearchAuthor.Size = new System.Drawing.Size(427, 345);
            this.dataGridSearchAuthor.TabIndex = 0;
            this.dataGridSearchAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAuthor_CellContentClick);
            this.dataGridSearchAuthor.SelectionChanged += new System.EventHandler(this.dataGridSearchAuthor_SelectionChanged);
            // 
            // textBoxSearchAuthor
            // 
            this.textBoxSearchAuthor.Location = new System.Drawing.Point(141, 60);
            this.textBoxSearchAuthor.Name = "textBoxSearchAuthor";
            this.textBoxSearchAuthor.Size = new System.Drawing.Size(248, 20);
            this.textBoxSearchAuthor.TabIndex = 1;
            this.textBoxSearchAuthor.TextChanged += new System.EventHandler(this.textBoxSearchAuthor_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 140);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(248, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(141, 172);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(248, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // buttonUpdateAuthor
            // 
            this.buttonUpdateAuthor.Location = new System.Drawing.Point(97, 282);
            this.buttonUpdateAuthor.Name = "buttonUpdateAuthor";
            this.buttonUpdateAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateAuthor.TabIndex = 4;
            this.buttonUpdateAuthor.Text = "Update";
            this.buttonUpdateAuthor.UseVisualStyleBackColor = true;
            this.buttonUpdateAuthor.Click += new System.EventHandler(this.buttonUpdateAuthor_Click);
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(210, 282);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAuthor.TabIndex = 5;
            this.buttonDeleteAuthor.Text = "Delete";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.buttonDeleteAuthor_Click);
            // 
            // buttonCancelAuthor
            // 
            this.buttonCancelAuthor.Location = new System.Drawing.Point(314, 282);
            this.buttonCancelAuthor.Name = "buttonCancelAuthor";
            this.buttonCancelAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAuthor.TabIndex = 6;
            this.buttonCancelAuthor.Text = "Cancel";
            this.buttonCancelAuthor.UseVisualStyleBackColor = true;
            this.buttonCancelAuthor.Click += new System.EventHandler(this.buttonCancelAuthor_Click);
            // 
            // labelSearchAuthor
            // 
            this.labelSearchAuthor.AutoSize = true;
            this.labelSearchAuthor.Location = new System.Drawing.Point(73, 63);
            this.labelSearchAuthor.Name = "labelSearchAuthor";
            this.labelSearchAuthor.Size = new System.Drawing.Size(44, 13);
            this.labelSearchAuthor.TabIndex = 7;
            this.labelSearchAuthor.Text = "Search:";
            // 
            // labelNameAuthor
            // 
            this.labelNameAuthor.AutoSize = true;
            this.labelNameAuthor.Location = new System.Drawing.Point(73, 140);
            this.labelNameAuthor.Name = "labelNameAuthor";
            this.labelNameAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelNameAuthor.TabIndex = 8;
            this.labelNameAuthor.Text = "Name:";
            // 
            // labelSurnameAuthor
            // 
            this.labelSurnameAuthor.AutoSize = true;
            this.labelSurnameAuthor.Location = new System.Drawing.Point(73, 175);
            this.labelSurnameAuthor.Name = "labelSurnameAuthor";
            this.labelSurnameAuthor.Size = new System.Drawing.Size(52, 13);
            this.labelSurnameAuthor.TabIndex = 9;
            this.labelSurnameAuthor.Text = "Surname:";
            // 
            // labelEditAuthor
            // 
            this.labelEditAuthor.AutoSize = true;
            this.labelEditAuthor.Location = new System.Drawing.Point(239, 111);
            this.labelEditAuthor.Name = "labelEditAuthor";
            this.labelEditAuthor.Size = new System.Drawing.Size(28, 13);
            this.labelEditAuthor.TabIndex = 10;
            this.labelEditAuthor.Text = "Edit:";
            // 
            // EditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 345);
            this.Controls.Add(this.labelEditAuthor);
            this.Controls.Add(this.labelSurnameAuthor);
            this.Controls.Add(this.labelNameAuthor);
            this.Controls.Add(this.labelSearchAuthor);
            this.Controls.Add(this.buttonCancelAuthor);
            this.Controls.Add(this.buttonDeleteAuthor);
            this.Controls.Add(this.buttonUpdateAuthor);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSearchAuthor);
            this.Controls.Add(this.dataGridSearchAuthor);
            this.Name = "EditAuthor";
            this.Text = "EditAuthor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSearchAuthor;
        private System.Windows.Forms.TextBox textBoxSearchAuthor;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button buttonUpdateAuthor;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.Button buttonCancelAuthor;
        private System.Windows.Forms.Label labelSearchAuthor;
        private System.Windows.Forms.Label labelNameAuthor;
        private System.Windows.Forms.Label labelSurnameAuthor;
        private System.Windows.Forms.Label labelEditAuthor;
    }
}