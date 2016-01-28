namespace Library.GUI
{
    partial class AddUser
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.comboBoxUserRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.groupBoxDown = new System.Windows.Forms.GroupBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBoxTop.SuspendLayout();
            this.groupBoxDown.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxName.Location = new System.Drawing.Point(3, 32);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(555, 21);
            this.txtBoxName.TabIndex = 0;
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.textBoxPass);
            this.groupBoxTop.Controls.Add(this.lblPass);
            this.groupBoxTop.Controls.Add(this.comboBoxUserRole);
            this.groupBoxTop.Controls.Add(this.lblRole);
            this.groupBoxTop.Controls.Add(this.textBoxEmail);
            this.groupBoxTop.Controls.Add(this.lblEmail);
            this.groupBoxTop.Controls.Add(this.textBoxSurname);
            this.groupBoxTop.Controls.Add(this.lblSurname);
            this.groupBoxTop.Controls.Add(this.txtBoxName);
            this.groupBoxTop.Controls.Add(this.lblName);
            this.groupBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxTop.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(561, 215);
            this.groupBoxTop.TabIndex = 1;
            this.groupBoxTop.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(3, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSurname.Location = new System.Drawing.Point(3, 68);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(555, 21);
            this.textBoxSurname.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurname.Location = new System.Drawing.Point(3, 53);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 15);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.Location = new System.Drawing.Point(3, 104);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(555, 21);
            this.textBoxEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmail.Location = new System.Drawing.Point(3, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // comboBoxUserRole
            // 
            this.comboBoxUserRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxUserRole.FormattingEnabled = true;
            this.comboBoxUserRole.Location = new System.Drawing.Point(3, 140);
            this.comboBoxUserRole.Name = "comboBoxUserRole";
            this.comboBoxUserRole.Size = new System.Drawing.Size(555, 23);
            this.comboBoxUserRole.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRole.Location = new System.Drawing.Point(3, 125);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 15);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role:";
            // 
            // groupBoxDown
            // 
            this.groupBoxDown.Controls.Add(this.btnCancel);
            this.groupBoxDown.Controls.Add(this.btnSaveUser);
            this.groupBoxDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDown.Location = new System.Drawing.Point(0, 236);
            this.groupBoxDown.Name = "groupBoxDown";
            this.groupBoxDown.Size = new System.Drawing.Size(561, 52);
            this.groupBoxDown.TabIndex = 5;
            this.groupBoxDown.TabStop = false;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPass.Location = new System.Drawing.Point(3, 178);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(555, 21);
            this.textBoxPass.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPass.Location = new System.Drawing.Point(3, 163);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(73, 15);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password:";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveUser.Location = new System.Drawing.Point(3, 17);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 32);
            this.btnSaveUser.TabIndex = 6;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(483, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.lblMsg);
            this.groupBoxMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxMsg.Location = new System.Drawing.Point(0, 288);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(561, 35);
            this.groupBoxMsg.TabIndex = 6;
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
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 323);
            this.Controls.Add(this.groupBoxDown);
            this.Controls.Add(this.groupBoxMsg);
            this.Controls.Add(this.groupBoxTop);
            this.Name = "AddUser";
            this.Text = "Add a new User";
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.groupBoxDown.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBoxMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox comboBoxUserRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.GroupBox groupBoxDown;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Label lblMsg;
    }
}