namespace Library.GUI
{
    partial class AddAuthor
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
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorSurname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonSaveAuthor = new System.Windows.Forms.Button();
            this.buttonCancelAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Location = new System.Drawing.Point(94, 47);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(248, 20);
            this.textBoxAuthorName.TabIndex = 0;
            // 
            // textBoxAuthorSurname
            // 
            this.textBoxAuthorSurname.Location = new System.Drawing.Point(94, 79);
            this.textBoxAuthorSurname.Name = "textBoxAuthorSurname";
            this.textBoxAuthorSurname.Size = new System.Drawing.Size(248, 20);
            this.textBoxAuthorSurname.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(26, 82);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(52, 13);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname:";
            // 
            // buttonSaveAuthor
            // 
            this.buttonSaveAuthor.Location = new System.Drawing.Point(95, 144);
            this.buttonSaveAuthor.Name = "buttonSaveAuthor";
            this.buttonSaveAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAuthor.TabIndex = 4;
            this.buttonSaveAuthor.Text = "Save";
            this.buttonSaveAuthor.UseVisualStyleBackColor = true;
            this.buttonSaveAuthor.Click += new System.EventHandler(this.buttonSaveAuthor_Click);
            // 
            // buttonCancelAuthor
            // 
            this.buttonCancelAuthor.Location = new System.Drawing.Point(241, 144);
            this.buttonCancelAuthor.Name = "buttonCancelAuthor";
            this.buttonCancelAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAuthor.TabIndex = 5;
            this.buttonCancelAuthor.Text = "Cancel";
            this.buttonCancelAuthor.UseVisualStyleBackColor = true;
            this.buttonCancelAuthor.Click += new System.EventHandler(this.buttonCancelAuthor_Click);
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 237);
            this.Controls.Add(this.buttonCancelAuthor);
            this.Controls.Add(this.buttonSaveAuthor);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAuthorSurname);
            this.Controls.Add(this.textBoxAuthorName);
            this.Name = "AddAuthor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.TextBox textBoxAuthorSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonSaveAuthor;
        private System.Windows.Forms.Button buttonCancelAuthor;
    }
}