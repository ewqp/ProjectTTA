namespace Library.GUI
{
    partial class AddGenre
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.buttonSaveGenre = new System.Windows.Forms.Button();
            this.buttonCancelGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(94, 47);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(248, 20);
            this.textBoxGenre.TabIndex = 2;
            // 
            // buttonSaveGenre
            // 
            this.buttonSaveGenre.Location = new System.Drawing.Point(94, 189);
            this.buttonSaveGenre.Name = "buttonSaveGenre";
            this.buttonSaveGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveGenre.TabIndex = 4;
            this.buttonSaveGenre.Text = "Save";
            this.buttonSaveGenre.UseVisualStyleBackColor = true;
            this.buttonSaveGenre.Click += new System.EventHandler(this.buttonSaveGenre_Click);
            // 
            // buttonCancelGenre
            // 
            this.buttonCancelGenre.Location = new System.Drawing.Point(206, 189);
            this.buttonCancelGenre.Name = "buttonCancelGenre";
            this.buttonCancelGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelGenre.TabIndex = 5;
            this.buttonCancelGenre.Text = "Cancel";
            this.buttonCancelGenre.UseVisualStyleBackColor = true;
            this.buttonCancelGenre.Click += new System.EventHandler(this.buttonCancelGenre_Click);
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 237);
            this.Controls.Add(this.buttonCancelGenre);
            this.Controls.Add(this.buttonSaveGenre);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.label1);
            this.Name = "AddGenre";
            this.Text = "AddGenre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Button buttonSaveGenre;
        private System.Windows.Forms.Button buttonCancelGenre;
    }
}