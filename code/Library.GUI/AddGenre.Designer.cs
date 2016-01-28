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
            this.lblGenre = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.buttonSaveGenre = new System.Windows.Forms.Button();
            this.buttonCancelGenre = new System.Windows.Forms.Button();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.groupBoxDown = new System.Windows.Forms.GroupBox();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBoxTop.SuspendLayout();
            this.groupBoxDown.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGenre.Location = new System.Drawing.Point(3, 17);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(50, 15);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Genre:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGenre.Location = new System.Drawing.Point(3, 32);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(551, 21);
            this.textBoxGenre.TabIndex = 2;
            // 
            // buttonSaveGenre
            // 
            this.buttonSaveGenre.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSaveGenre.Location = new System.Drawing.Point(3, 17);
            this.buttonSaveGenre.Name = "buttonSaveGenre";
            this.buttonSaveGenre.Size = new System.Drawing.Size(75, 31);
            this.buttonSaveGenre.TabIndex = 4;
            this.buttonSaveGenre.Text = "Save";
            this.buttonSaveGenre.UseVisualStyleBackColor = true;
            this.buttonSaveGenre.Click += new System.EventHandler(this.buttonSaveGenre_Click);
            // 
            // buttonCancelGenre
            // 
            this.buttonCancelGenre.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancelGenre.Location = new System.Drawing.Point(479, 17);
            this.buttonCancelGenre.Name = "buttonCancelGenre";
            this.buttonCancelGenre.Size = new System.Drawing.Size(75, 31);
            this.buttonCancelGenre.TabIndex = 5;
            this.buttonCancelGenre.Text = "Cancel";
            this.buttonCancelGenre.UseVisualStyleBackColor = true;
            this.buttonCancelGenre.Click += new System.EventHandler(this.buttonCancelGenre_Click);
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.textBoxGenre);
            this.groupBoxTop.Controls.Add(this.lblGenre);
            this.groupBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxTop.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(557, 100);
            this.groupBoxTop.TabIndex = 6;
            this.groupBoxTop.TabStop = false;
            // 
            // groupBoxDown
            // 
            this.groupBoxDown.Controls.Add(this.buttonCancelGenre);
            this.groupBoxDown.Controls.Add(this.buttonSaveGenre);
            this.groupBoxDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDown.Location = new System.Drawing.Point(0, 185);
            this.groupBoxDown.Name = "groupBoxDown";
            this.groupBoxDown.Size = new System.Drawing.Size(557, 51);
            this.groupBoxDown.TabIndex = 7;
            this.groupBoxDown.TabStop = false;
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.lblMsg);
            this.groupBoxMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMsg.Location = new System.Drawing.Point(0, 236);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(557, 39);
            this.groupBoxMsg.TabIndex = 8;
            this.groupBoxMsg.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(3, 16);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 15);
            this.lblMsg.TabIndex = 0;
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 275);
            this.Controls.Add(this.groupBoxDown);
            this.Controls.Add(this.groupBoxMsg);
            this.Controls.Add(this.groupBoxTop);
            this.Name = "AddGenre";
            this.Text = "AddGenre";
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.groupBoxDown.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBoxMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Button buttonSaveGenre;
        private System.Windows.Forms.Button buttonCancelGenre;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.GroupBox groupBoxDown;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Label lblMsg;
    }
}