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
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBoxSurname = new System.Windows.Forms.GroupBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.groupBoxRole = new System.Windows.Forms.GroupBox();
            this.comboBoxUserRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.groupBoxPass = new System.Windows.Forms.GroupBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxName.SuspendLayout();
            this.groupBoxSurname.SuspendLayout();
            this.groupBoxEmail.SuspendLayout();
            this.groupBoxRole.SuspendLayout();
            this.groupBoxPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBoxName.Location = new System.Drawing.Point(41, 16);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(306, 20);
            this.txtBoxName.TabIndex = 0;
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.txtBoxName);
            this.groupBoxName.Controls.Add(this.lblName);
            this.groupBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxName.Location = new System.Drawing.Point(0, 0);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(497, 52);
            this.groupBoxName.TabIndex = 1;
            this.groupBoxName.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Location = new System.Drawing.Point(3, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // groupBoxSurname
            // 
            this.groupBoxSurname.Controls.Add(this.textBoxSurname);
            this.groupBoxSurname.Controls.Add(this.lblSurname);
            this.groupBoxSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSurname.Location = new System.Drawing.Point(0, 52);
            this.groupBoxSurname.Name = "groupBoxSurname";
            this.groupBoxSurname.Size = new System.Drawing.Size(497, 53);
            this.groupBoxSurname.TabIndex = 2;
            this.groupBoxSurname.TabStop = false;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxSurname.Location = new System.Drawing.Point(55, 16);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(292, 20);
            this.textBoxSurname.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSurname.Location = new System.Drawing.Point(3, 16);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.textBoxEmail);
            this.groupBoxEmail.Controls.Add(this.lblEmail);
            this.groupBoxEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEmail.Location = new System.Drawing.Point(0, 105);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Size = new System.Drawing.Size(497, 50);
            this.groupBoxEmail.TabIndex = 3;
            this.groupBoxEmail.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxEmail.Location = new System.Drawing.Point(38, 16);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(309, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmail.Location = new System.Drawing.Point(3, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // groupBoxRole
            // 
            this.groupBoxRole.Controls.Add(this.comboBoxUserRole);
            this.groupBoxRole.Controls.Add(this.lblRole);
            this.groupBoxRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRole.Location = new System.Drawing.Point(0, 155);
            this.groupBoxRole.Name = "groupBoxRole";
            this.groupBoxRole.Size = new System.Drawing.Size(497, 53);
            this.groupBoxRole.TabIndex = 4;
            this.groupBoxRole.TabStop = false;
            // 
            // comboBoxUserRole
            // 
            this.comboBoxUserRole.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxUserRole.FormattingEnabled = true;
            this.comboBoxUserRole.Location = new System.Drawing.Point(35, 16);
            this.comboBoxUserRole.Name = "comboBoxUserRole";
            this.comboBoxUserRole.Size = new System.Drawing.Size(312, 21);
            this.comboBoxUserRole.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRole.Location = new System.Drawing.Point(3, 16);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role:";
            // 
            // groupBoxPass
            // 
            this.groupBoxPass.Controls.Add(this.textBoxPass);
            this.groupBoxPass.Controls.Add(this.lblPass);
            this.groupBoxPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPass.Location = new System.Drawing.Point(0, 208);
            this.groupBoxPass.Name = "groupBoxPass";
            this.groupBoxPass.Size = new System.Drawing.Size(497, 55);
            this.groupBoxPass.TabIndex = 5;
            this.groupBoxPass.TabStop = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPass.Location = new System.Drawing.Point(3, 16);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxPass.Location = new System.Drawing.Point(59, 16);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(288, 20);
            this.textBoxPass.TabIndex = 1;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(88, 282);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 6;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 329);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.groupBoxPass);
            this.Controls.Add(this.groupBoxRole);
            this.Controls.Add(this.groupBoxEmail);
            this.Controls.Add(this.groupBoxSurname);
            this.Controls.Add(this.groupBoxName);
            this.Name = "AddUser";
            this.Text = "Add a new User";
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxSurname.ResumeLayout(false);
            this.groupBoxSurname.PerformLayout();
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            this.groupBoxRole.ResumeLayout(false);
            this.groupBoxRole.PerformLayout();
            this.groupBoxPass.ResumeLayout(false);
            this.groupBoxPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBoxSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox groupBoxRole;
        private System.Windows.Forms.ComboBox comboBoxUserRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.GroupBox groupBoxPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnCancel;
    }
}