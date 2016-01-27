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
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.groupBoxDown = new System.Windows.Forms.GroupBox();
            this.groupBoxMgs = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBoxTop.SuspendLayout();
            this.groupBoxDown.SuspendLayout();
            this.groupBoxMgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAuthorName.Location = new System.Drawing.Point(3, 32);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(506, 21);
            this.textBoxAuthorName.TabIndex = 0;
            // 
            // textBoxAuthorSurname
            // 
            this.textBoxAuthorSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAuthorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAuthorSurname.Location = new System.Drawing.Point(3, 68);
            this.textBoxAuthorSurname.Name = "textBoxAuthorSurname";
            this.textBoxAuthorSurname.Size = new System.Drawing.Size(506, 21);
            this.textBoxAuthorSurname.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Location = new System.Drawing.Point(3, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSurname.Location = new System.Drawing.Point(3, 53);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(69, 15);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname:";
            // 
            // buttonSaveAuthor
            // 
            this.buttonSaveAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSaveAuthor.Location = new System.Drawing.Point(3, 17);
            this.buttonSaveAuthor.Name = "buttonSaveAuthor";
            this.buttonSaveAuthor.Size = new System.Drawing.Size(75, 45);
            this.buttonSaveAuthor.TabIndex = 4;
            this.buttonSaveAuthor.Text = "Save";
            this.buttonSaveAuthor.UseVisualStyleBackColor = true;
            this.buttonSaveAuthor.Click += new System.EventHandler(this.buttonSaveAuthor_Click);
            // 
            // buttonCancelAuthor
            // 
            this.buttonCancelAuthor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancelAuthor.Location = new System.Drawing.Point(434, 17);
            this.buttonCancelAuthor.Name = "buttonCancelAuthor";
            this.buttonCancelAuthor.Size = new System.Drawing.Size(75, 45);
            this.buttonCancelAuthor.TabIndex = 5;
            this.buttonCancelAuthor.Text = "Cancel";
            this.buttonCancelAuthor.UseVisualStyleBackColor = true;
            this.buttonCancelAuthor.Click += new System.EventHandler(this.buttonCancelAuthor_Click);
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.textBoxAuthorSurname);
            this.groupBoxTop.Controls.Add(this.labelSurname);
            this.groupBoxTop.Controls.Add(this.textBoxAuthorName);
            this.groupBoxTop.Controls.Add(this.labelName);
            this.groupBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxTop.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(512, 116);
            this.groupBoxTop.TabIndex = 6;
            this.groupBoxTop.TabStop = false;
            // 
            // groupBoxDown
            // 
            this.groupBoxDown.Controls.Add(this.buttonCancelAuthor);
            this.groupBoxDown.Controls.Add(this.buttonSaveAuthor);
            this.groupBoxDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDown.Location = new System.Drawing.Point(0, 122);
            this.groupBoxDown.Name = "groupBoxDown";
            this.groupBoxDown.Size = new System.Drawing.Size(512, 65);
            this.groupBoxDown.TabIndex = 7;
            this.groupBoxDown.TabStop = false;
            // 
            // groupBoxMgs
            // 
            this.groupBoxMgs.Controls.Add(this.lblMsg);
            this.groupBoxMgs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxMgs.Location = new System.Drawing.Point(0, 187);
            this.groupBoxMgs.Name = "groupBoxMgs";
            this.groupBoxMgs.Size = new System.Drawing.Size(512, 39);
            this.groupBoxMgs.TabIndex = 8;
            this.groupBoxMgs.TabStop = false;
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
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 226);
            this.Controls.Add(this.groupBoxDown);
            this.Controls.Add(this.groupBoxTop);
            this.Controls.Add(this.groupBoxMgs);
            this.Name = "AddAuthor";
            this.Text = "Add a new author";
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.groupBoxDown.ResumeLayout(false);
            this.groupBoxMgs.ResumeLayout(false);
            this.groupBoxMgs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.TextBox textBoxAuthorSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonSaveAuthor;
        private System.Windows.Forms.Button buttonCancelAuthor;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.GroupBox groupBoxDown;
        private System.Windows.Forms.GroupBox groupBoxMgs;
        private System.Windows.Forms.Label lblMsg;
    }
}