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
            this.textBoxSearchGenre = new System.Windows.Forms.TextBox();
            this.textBoxGenreName = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.buttonUpdateGenre = new System.Windows.Forms.Button();
            this.buttonDeleteGenre = new System.Windows.Forms.Button();
            this.buttonCancelGenre = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxBtn = new System.Windows.Forms.GroupBox();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchGenre)).BeginInit();
            this.groupBoxRight.SuspendLayout();
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxBtn.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSearchGenre
            // 
            this.dataGridSearchGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genre});
            this.dataGridSearchGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSearchGenre.Location = new System.Drawing.Point(3, 16);
            this.dataGridSearchGenre.Name = "dataGridSearchGenre";
            this.dataGridSearchGenre.Size = new System.Drawing.Size(314, 326);
            this.dataGridSearchGenre.TabIndex = 0;
            this.dataGridSearchGenre.SelectionChanged += new System.EventHandler(this.dataGridSearchGenre_SelectionChanged);
            // 
            // textBoxSearchGenre
            // 
            this.textBoxSearchGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchGenre.Location = new System.Drawing.Point(3, 17);
            this.textBoxSearchGenre.Name = "textBoxSearchGenre";
            this.textBoxSearchGenre.Size = new System.Drawing.Size(388, 21);
=======
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.groupBoxGenreSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxGenreEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxRigth = new System.Windows.Forms.GroupBox();
            this.dataGridGenres = new System.Windows.Forms.DataGridView();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxGenreBtn = new System.Windows.Forms.GroupBox();
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxGenreSearch.SuspendLayout();
            this.groupBoxGenreEdit.SuspendLayout();
            this.groupBoxRigth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenres)).BeginInit();
            this.groupBoxGenreBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearchGenre
            // 
            this.textBoxSearchGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchGenre.Location = new System.Drawing.Point(3, 17);
            this.textBoxSearchGenre.Name = "textBoxSearchGenre";
            this.textBoxSearchGenre.Size = new System.Drawing.Size(366, 20);
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            this.textBoxSearchGenre.TabIndex = 1;
            this.textBoxSearchGenre.TextChanged += new System.EventHandler(this.textBoxSearchGenre_TextChanged);
            // 
            // textBoxGenreName
            // 
            this.textBoxGenreName.Dock = System.Windows.Forms.DockStyle.Top;
<<<<<<< HEAD
            this.textBoxGenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGenreName.Location = new System.Drawing.Point(3, 32);
            this.textBoxGenreName.Name = "textBoxGenreName";
            this.textBoxGenreName.Size = new System.Drawing.Size(388, 21);
=======
            this.textBoxGenreName.Location = new System.Drawing.Point(3, 32);
            this.textBoxGenreName.Name = "textBoxGenreName";
            this.textBoxGenreName.Size = new System.Drawing.Size(366, 21);
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            this.textBoxGenreName.TabIndex = 2;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGenre.Location = new System.Drawing.Point(3, 17);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(50, 15);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre:";
            // 
            // buttonUpdateGenre
            // 
            this.buttonUpdateGenre.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUpdateGenre.Location = new System.Drawing.Point(3, 17);
            this.buttonUpdateGenre.Name = "buttonUpdateGenre";
<<<<<<< HEAD
            this.buttonUpdateGenre.Size = new System.Drawing.Size(75, 34);
=======
            this.buttonUpdateGenre.Size = new System.Drawing.Size(75, 40);
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            this.buttonUpdateGenre.TabIndex = 6;
            this.buttonUpdateGenre.Text = "Update";
            this.buttonUpdateGenre.UseVisualStyleBackColor = true;
            this.buttonUpdateGenre.Click += new System.EventHandler(this.buttonUpdateGenre_Click);
            // 
            // buttonDeleteGenre
            // 
            this.buttonDeleteGenre.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDeleteGenre.Location = new System.Drawing.Point(78, 17);
            this.buttonDeleteGenre.Name = "buttonDeleteGenre";
<<<<<<< HEAD
            this.buttonDeleteGenre.Size = new System.Drawing.Size(75, 34);
=======
            this.buttonDeleteGenre.Size = new System.Drawing.Size(75, 40);
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            this.buttonDeleteGenre.TabIndex = 7;
            this.buttonDeleteGenre.Text = "Delete";
            this.buttonDeleteGenre.UseVisualStyleBackColor = true;
            this.buttonDeleteGenre.Click += new System.EventHandler(this.buttonDeleteGenre_Click);
            // 
            // buttonCancelGenre
            // 
            this.buttonCancelGenre.Dock = System.Windows.Forms.DockStyle.Right;
<<<<<<< HEAD
            this.buttonCancelGenre.Location = new System.Drawing.Point(316, 17);
            this.buttonCancelGenre.Name = "buttonCancelGenre";
            this.buttonCancelGenre.Size = new System.Drawing.Size(75, 34);
=======
            this.buttonCancelGenre.Location = new System.Drawing.Point(294, 17);
            this.buttonCancelGenre.Name = "buttonCancelGenre";
            this.buttonCancelGenre.Size = new System.Drawing.Size(75, 40);
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            this.buttonCancelGenre.TabIndex = 8;
            this.buttonCancelGenre.Text = "Cancel";
            this.buttonCancelGenre.UseVisualStyleBackColor = true;
            this.buttonCancelGenre.Click += new System.EventHandler(this.buttonCancelGenre_Click);
            // 
<<<<<<< HEAD
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.dataGridSearchGenre);
            this.groupBoxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxRight.Location = new System.Drawing.Point(406, 0);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(320, 345);
            this.groupBoxRight.TabIndex = 9;
            this.groupBoxRight.TabStop = false;
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.groupBoxBtn);
            this.groupBoxLeft.Controls.Add(this.groupBoxMsg);
            this.groupBoxLeft.Controls.Add(this.groupBoxEdit);
            this.groupBoxLeft.Controls.Add(this.groupBoxSearch);
            this.groupBoxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(400, 345);
            this.groupBoxLeft.TabIndex = 10;
            this.groupBoxLeft.TabStop = false;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.textBoxGenreName);
            this.groupBoxEdit.Controls.Add(this.lblGenre);
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEdit.Location = new System.Drawing.Point(3, 61);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(394, 100);
            this.groupBoxEdit.TabIndex = 1;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit:";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearchGenre);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSearch.Location = new System.Drawing.Point(3, 16);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(394, 45);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search:";
            // 
            // groupBoxBtn
            // 
            this.groupBoxBtn.Controls.Add(this.buttonDeleteGenre);
            this.groupBoxBtn.Controls.Add(this.buttonCancelGenre);
            this.groupBoxBtn.Controls.Add(this.buttonUpdateGenre);
            this.groupBoxBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBtn.Location = new System.Drawing.Point(3, 251);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(394, 54);
            this.groupBoxBtn.TabIndex = 1;
            this.groupBoxBtn.TabStop = false;
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.lblMsg);
            this.groupBoxMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxMsg.Location = new System.Drawing.Point(3, 305);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(394, 37);
            this.groupBoxMsg.TabIndex = 2;
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
=======
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.groupBoxGenreBtn);
            this.groupBoxLeft.Controls.Add(this.groupBoxGenreEdit);
            this.groupBoxLeft.Controls.Add(this.groupBoxGenreSearch);
            this.groupBoxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(378, 301);
            this.groupBoxLeft.TabIndex = 9;
            this.groupBoxLeft.TabStop = false;
            // 
            // groupBoxGenreSearch
            // 
            this.groupBoxGenreSearch.Controls.Add(this.textBoxSearchGenre);
            this.groupBoxGenreSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGenreSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxGenreSearch.Location = new System.Drawing.Point(3, 16);
            this.groupBoxGenreSearch.Name = "groupBoxGenreSearch";
            this.groupBoxGenreSearch.Size = new System.Drawing.Size(372, 107);
            this.groupBoxGenreSearch.TabIndex = 9;
            this.groupBoxGenreSearch.TabStop = false;
            this.groupBoxGenreSearch.Text = "Search:";
            // 
            // groupBoxGenreEdit
            // 
            this.groupBoxGenreEdit.Controls.Add(this.textBoxGenreName);
            this.groupBoxGenreEdit.Controls.Add(this.lblGenre);
            this.groupBoxGenreEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGenreEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxGenreEdit.Location = new System.Drawing.Point(3, 123);
            this.groupBoxGenreEdit.Name = "groupBoxGenreEdit";
            this.groupBoxGenreEdit.Size = new System.Drawing.Size(372, 168);
            this.groupBoxGenreEdit.TabIndex = 10;
            this.groupBoxGenreEdit.TabStop = false;
            this.groupBoxGenreEdit.Text = "Edit:";
            // 
            // groupBoxRigth
            // 
            this.groupBoxRigth.Controls.Add(this.dataGridGenres);
            this.groupBoxRigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxRigth.Location = new System.Drawing.Point(384, 0);
            this.groupBoxRigth.Name = "groupBoxRigth";
            this.groupBoxRigth.Size = new System.Drawing.Size(326, 301);
            this.groupBoxRigth.TabIndex = 10;
            this.groupBoxRigth.TabStop = false;
            // 
            // dataGridGenres
            // 
            this.dataGridGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genre});
            this.dataGridGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGenres.Location = new System.Drawing.Point(3, 16);
            this.dataGridGenres.Name = "dataGridGenres";
            this.dataGridGenres.Size = new System.Drawing.Size(320, 282);
            this.dataGridGenres.TabIndex = 0;
            this.dataGridGenres.Click += new System.EventHandler(this.dataGridGenres_Click);
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
<<<<<<< HEAD
=======
            // groupBoxGenreBtn
            // 
            this.groupBoxGenreBtn.Controls.Add(this.buttonDeleteGenre);
            this.groupBoxGenreBtn.Controls.Add(this.buttonUpdateGenre);
            this.groupBoxGenreBtn.Controls.Add(this.buttonCancelGenre);
            this.groupBoxGenreBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxGenreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxGenreBtn.Location = new System.Drawing.Point(3, 238);
            this.groupBoxGenreBtn.Name = "groupBoxGenreBtn";
            this.groupBoxGenreBtn.Size = new System.Drawing.Size(372, 60);
            this.groupBoxGenreBtn.TabIndex = 5;
            this.groupBoxGenreBtn.TabStop = false;
            // 
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            // EditGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(726, 345);
            this.Controls.Add(this.groupBoxLeft);
            this.Controls.Add(this.groupBoxRight);
            this.Name = "EditGenre";
            this.Text = "EditGenre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchGenre)).EndInit();
            this.groupBoxRight.ResumeLayout(false);
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxBtn.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBoxMsg.PerformLayout();
=======
            this.ClientSize = new System.Drawing.Size(710, 301);
            this.Controls.Add(this.groupBoxRigth);
            this.Controls.Add(this.groupBoxLeft);
            this.Name = "EditGenre";
            this.Text = "Edit genres";
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxGenreSearch.ResumeLayout(false);
            this.groupBoxGenreSearch.PerformLayout();
            this.groupBoxGenreEdit.ResumeLayout(false);
            this.groupBoxGenreEdit.PerformLayout();
            this.groupBoxRigth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenres)).EndInit();
            this.groupBoxGenreBtn.ResumeLayout(false);
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearchGenre;
        private System.Windows.Forms.TextBox textBoxGenreName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button buttonUpdateGenre;
        private System.Windows.Forms.Button buttonDeleteGenre;
        private System.Windows.Forms.Button buttonCancelGenre;
<<<<<<< HEAD
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
=======
        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.GroupBox groupBoxRigth;
        private System.Windows.Forms.DataGridView dataGridGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.GroupBox groupBoxGenreSearch;
        private System.Windows.Forms.GroupBox groupBoxGenreEdit;
        private System.Windows.Forms.GroupBox groupBoxGenreBtn;
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
    }
}