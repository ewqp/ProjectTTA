namespace Library.GUI
{
    partial class EditGenre
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
            this.dataGridSearchGenre = new System.Windows.Forms.DataGridView();
            this.textBoxSearchGenre = new System.Windows.Forms.TextBox();
            this.textBoxGenreName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdateGenre = new System.Windows.Forms.Button();
            this.buttonDeleteGenre = new System.Windows.Forms.Button();
            this.buttonCancelGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSearchGenre
            // 
            this.dataGridSearchGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchGenre.Location = new System.Drawing.Point(431, 0);
            this.dataGridSearchGenre.Name = "dataGridSearchGenre";
            this.dataGridSearchGenre.Size = new System.Drawing.Size(427, 345);
            this.dataGridSearchGenre.TabIndex = 0;
            this.dataGridSearchGenre.SelectionChanged += new System.EventHandler(this.dataGridSearchGenre_SelectionChanged);
            // 
            // textBoxSearchGenre
            // 
            this.textBoxSearchGenre.Location = new System.Drawing.Point(141, 60);
            this.textBoxSearchGenre.Name = "textBoxSearchGenre";
            this.textBoxSearchGenre.Size = new System.Drawing.Size(248, 20);
            this.textBoxSearchGenre.TabIndex = 1;
            this.textBoxSearchGenre.TextChanged += new System.EventHandler(this.textBoxSearchGenre_TextChanged);
            // 
            // textBoxGenreName
            // 
            this.textBoxGenreName.Location = new System.Drawing.Point(141, 140);
            this.textBoxGenreName.Name = "textBoxGenreName";
            this.textBoxGenreName.Size = new System.Drawing.Size(248, 20);
            this.textBoxGenreName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edit:";
            // 
            // buttonUpdateGenre
            // 
            this.buttonUpdateGenre.Location = new System.Drawing.Point(97, 282);
            this.buttonUpdateGenre.Name = "buttonUpdateGenre";
            this.buttonUpdateGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateGenre.TabIndex = 6;
            this.buttonUpdateGenre.Text = "Update";
            this.buttonUpdateGenre.UseVisualStyleBackColor = true;
            this.buttonUpdateGenre.Click += new System.EventHandler(this.buttonUpdateGenre_Click);
            // 
            // buttonDeleteGenre
            // 
            this.buttonDeleteGenre.Location = new System.Drawing.Point(210, 282);
            this.buttonDeleteGenre.Name = "buttonDeleteGenre";
            this.buttonDeleteGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteGenre.TabIndex = 7;
            this.buttonDeleteGenre.Text = "Delete";
            this.buttonDeleteGenre.UseVisualStyleBackColor = true;
            // 
            // buttonCancelGenre
            // 
            this.buttonCancelGenre.Location = new System.Drawing.Point(314, 282);
            this.buttonCancelGenre.Name = "buttonCancelGenre";
            this.buttonCancelGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelGenre.TabIndex = 8;
            this.buttonCancelGenre.Text = "Cancel";
            this.buttonCancelGenre.UseVisualStyleBackColor = true;
            this.buttonCancelGenre.Click += new System.EventHandler(this.buttonCancelGenre_Click);
            // 
            // EditGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 345);
            this.Controls.Add(this.buttonCancelGenre);
            this.Controls.Add(this.buttonDeleteGenre);
            this.Controls.Add(this.buttonUpdateGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGenreName);
            this.Controls.Add(this.textBoxSearchGenre);
            this.Controls.Add(this.dataGridSearchGenre);
            this.Name = "EditGenre";
            this.Text = "EditGenre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSearchGenre;
        private System.Windows.Forms.TextBox textBoxSearchGenre;
        private System.Windows.Forms.TextBox textBoxGenreName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdateGenre;
        private System.Windows.Forms.Button buttonDeleteGenre;
        private System.Windows.Forms.Button buttonCancelGenre;
    }
}