namespace Library.GUI
{
    partial class AddAccount
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
            this.lblAccName = new System.Windows.Forms.Label();
            this.txtBoxAccName = new System.Windows.Forms.TextBox();
            this.lblAccSur = new System.Windows.Forms.Label();
            this.txtBoxAccSur = new System.Windows.Forms.TextBox();
            this.lblAccEmail = new System.Windows.Forms.Label();
            this.txtBoxAccEmail = new System.Windows.Forms.TextBox();
            this.btnSaveAcc = new System.Windows.Forms.Button();
            this.btnCancelAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Location = new System.Drawing.Point(31, 43);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(38, 13);
            this.lblAccName.TabIndex = 0;
            this.lblAccName.Text = "Name:";
            // 
            // txtBoxAccName
            // 
            this.txtBoxAccName.Location = new System.Drawing.Point(96, 40);
            this.txtBoxAccName.Name = "txtBoxAccName";
            this.txtBoxAccName.Size = new System.Drawing.Size(242, 20);
            this.txtBoxAccName.TabIndex = 1;
            // 
            // lblAccSur
            // 
            this.lblAccSur.AutoSize = true;
            this.lblAccSur.Location = new System.Drawing.Point(31, 96);
            this.lblAccSur.Name = "lblAccSur";
            this.lblAccSur.Size = new System.Drawing.Size(52, 13);
            this.lblAccSur.TabIndex = 2;
            this.lblAccSur.Text = "Surname:";
            // 
            // txtBoxAccSur
            // 
            this.txtBoxAccSur.Location = new System.Drawing.Point(96, 93);
            this.txtBoxAccSur.Name = "txtBoxAccSur";
            this.txtBoxAccSur.Size = new System.Drawing.Size(242, 20);
            this.txtBoxAccSur.TabIndex = 3;
            // 
            // lblAccEmail
            // 
            this.lblAccEmail.AutoSize = true;
            this.lblAccEmail.Location = new System.Drawing.Point(31, 148);
            this.lblAccEmail.Name = "lblAccEmail";
            this.lblAccEmail.Size = new System.Drawing.Size(35, 13);
            this.lblAccEmail.TabIndex = 4;
            this.lblAccEmail.Text = "Email:";
            // 
            // txtBoxAccEmail
            // 
            this.txtBoxAccEmail.Location = new System.Drawing.Point(96, 145);
            this.txtBoxAccEmail.Name = "txtBoxAccEmail";
            this.txtBoxAccEmail.Size = new System.Drawing.Size(242, 20);
            this.txtBoxAccEmail.TabIndex = 5;
            // 
            // btnSaveAcc
            // 
            this.btnSaveAcc.Location = new System.Drawing.Point(96, 215);
            this.btnSaveAcc.Name = "btnSaveAcc";
            this.btnSaveAcc.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAcc.TabIndex = 6;
            this.btnSaveAcc.Text = "Add";
            this.btnSaveAcc.UseVisualStyleBackColor = true;
            this.btnSaveAcc.Click += new System.EventHandler(this.btnSaveAcc_Click);
            // 
            // btnCancelAcc
            // 
            this.btnCancelAcc.Location = new System.Drawing.Point(263, 215);
            this.btnCancelAcc.Name = "btnCancelAcc";
            this.btnCancelAcc.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAcc.TabIndex = 7;
            this.btnCancelAcc.Text = "Cancel";
            this.btnCancelAcc.UseVisualStyleBackColor = true;
            this.btnCancelAcc.Click += new System.EventHandler(this.btnCancelAcc_Click);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 272);
            this.Controls.Add(this.btnCancelAcc);
            this.Controls.Add(this.btnSaveAcc);
            this.Controls.Add(this.txtBoxAccEmail);
            this.Controls.Add(this.lblAccEmail);
            this.Controls.Add(this.txtBoxAccSur);
            this.Controls.Add(this.lblAccSur);
            this.Controls.Add(this.txtBoxAccName);
            this.Controls.Add(this.lblAccName);
            this.Name = "AddAccount";
            this.Text = "Add a new account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.TextBox txtBoxAccName;
        private System.Windows.Forms.Label lblAccSur;
        private System.Windows.Forms.TextBox txtBoxAccSur;
        private System.Windows.Forms.Label lblAccEmail;
        private System.Windows.Forms.TextBox txtBoxAccEmail;
        private System.Windows.Forms.Button btnSaveAcc;
        private System.Windows.Forms.Button btnCancelAcc;
    }
}