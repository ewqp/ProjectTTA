namespace Library.GUI
{
    partial class EditAccount
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
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxSearchAcc = new System.Windows.Forms.TextBox();
            this.groupBoxEditAcc = new System.Windows.Forms.GroupBox();
            this.lblAccName = new System.Windows.Forms.Label();
            this.txtBoxAccName = new System.Windows.Forms.TextBox();
            this.lblAccSur = new System.Windows.Forms.Label();
            this.txtBoxAccSur = new System.Windows.Forms.TextBox();
            this.lblAccEmail = new System.Windows.Forms.Label();
            this.txtBoxAccEmail = new System.Windows.Forms.TextBox();
            this.groupBoxBtn = new System.Windows.Forms.GroupBox();
            this.btnAccUpdate = new System.Windows.Forms.Button();
            this.btnAccDel = new System.Windows.Forms.Button();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.dataGridAccs = new System.Windows.Forms.DataGridView();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxEditAcc.SuspendLayout();
            this.groupBoxBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.groupBoxEditAcc);
            this.groupBoxLeft.Controls.Add(this.groupBox1);
            this.groupBoxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(280, 296);
            this.groupBoxLeft.TabIndex = 0;
            this.groupBoxLeft.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxSearchAcc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search:";
            // 
            // txtBoxSearchAcc
            // 
            this.txtBoxSearchAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxSearchAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSearchAcc.Location = new System.Drawing.Point(3, 17);
            this.txtBoxSearchAcc.Name = "txtBoxSearchAcc";
            this.txtBoxSearchAcc.Size = new System.Drawing.Size(268, 20);
            this.txtBoxSearchAcc.TabIndex = 1;
            this.txtBoxSearchAcc.TextChanged += new System.EventHandler(this.txtBoxSearchAcc_TextChanged);
            // 
            // groupBoxEditAcc
            // 
            this.groupBoxEditAcc.Controls.Add(this.groupBoxBtn);
            this.groupBoxEditAcc.Controls.Add(this.txtBoxAccEmail);
            this.groupBoxEditAcc.Controls.Add(this.lblAccEmail);
            this.groupBoxEditAcc.Controls.Add(this.txtBoxAccSur);
            this.groupBoxEditAcc.Controls.Add(this.lblAccSur);
            this.groupBoxEditAcc.Controls.Add(this.txtBoxAccName);
            this.groupBoxEditAcc.Controls.Add(this.lblAccName);
            this.groupBoxEditAcc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxEditAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEditAcc.Location = new System.Drawing.Point(3, 89);
            this.groupBoxEditAcc.Name = "groupBoxEditAcc";
            this.groupBoxEditAcc.Size = new System.Drawing.Size(274, 204);
            this.groupBoxEditAcc.TabIndex = 1;
            this.groupBoxEditAcc.TabStop = false;
            this.groupBoxEditAcc.Text = "Edit:";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccName.Location = new System.Drawing.Point(3, 17);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(49, 15);
            this.lblAccName.TabIndex = 1;
            this.lblAccName.Text = "Name:";
            // 
            // txtBoxAccName
            // 
            this.txtBoxAccName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxAccName.Location = new System.Drawing.Point(3, 32);
            this.txtBoxAccName.Name = "txtBoxAccName";
            this.txtBoxAccName.Size = new System.Drawing.Size(268, 20);
            this.txtBoxAccName.TabIndex = 1;
            // 
            // lblAccSur
            // 
            this.lblAccSur.AutoSize = true;
            this.lblAccSur.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccSur.Location = new System.Drawing.Point(3, 52);
            this.lblAccSur.Name = "lblAccSur";
            this.lblAccSur.Size = new System.Drawing.Size(69, 15);
            this.lblAccSur.TabIndex = 1;
            this.lblAccSur.Text = "Surname:";
            // 
            // txtBoxAccSur
            // 
            this.txtBoxAccSur.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxAccSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxAccSur.Location = new System.Drawing.Point(3, 67);
            this.txtBoxAccSur.Name = "txtBoxAccSur";
            this.txtBoxAccSur.Size = new System.Drawing.Size(268, 20);
            this.txtBoxAccSur.TabIndex = 1;
            // 
            // lblAccEmail
            // 
            this.lblAccEmail.AutoSize = true;
            this.lblAccEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccEmail.Location = new System.Drawing.Point(3, 87);
            this.lblAccEmail.Name = "lblAccEmail";
            this.lblAccEmail.Size = new System.Drawing.Size(48, 15);
            this.lblAccEmail.TabIndex = 1;
            this.lblAccEmail.Text = "Email:";
            // 
            // txtBoxAccEmail
            // 
            this.txtBoxAccEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxAccEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxAccEmail.Location = new System.Drawing.Point(3, 102);
            this.txtBoxAccEmail.Name = "txtBoxAccEmail";
            this.txtBoxAccEmail.Size = new System.Drawing.Size(268, 20);
            this.txtBoxAccEmail.TabIndex = 1;
            // 
            // groupBoxBtn
            // 
            this.groupBoxBtn.Controls.Add(this.btnAccCancel);
            this.groupBoxBtn.Controls.Add(this.btnAccDel);
            this.groupBoxBtn.Controls.Add(this.btnAccUpdate);
            this.groupBoxBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxBtn.Location = new System.Drawing.Point(3, 148);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(268, 53);
            this.groupBoxBtn.TabIndex = 1;
            this.groupBoxBtn.TabStop = false;
            // 
            // btnAccUpdate
            // 
            this.btnAccUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccUpdate.Location = new System.Drawing.Point(3, 17);
            this.btnAccUpdate.Name = "btnAccUpdate";
            this.btnAccUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnAccUpdate.TabIndex = 1;
            this.btnAccUpdate.Text = "Update";
            this.btnAccUpdate.UseVisualStyleBackColor = true;
            this.btnAccUpdate.Click += new System.EventHandler(this.btnAccUpdate_Click);
            // 
            // btnAccDel
            // 
            this.btnAccDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccDel.Location = new System.Drawing.Point(78, 17);
            this.btnAccDel.Name = "btnAccDel";
            this.btnAccDel.Size = new System.Drawing.Size(75, 33);
            this.btnAccDel.TabIndex = 1;
            this.btnAccDel.Text = "Delete";
            this.btnAccDel.UseVisualStyleBackColor = true;
            this.btnAccDel.Click += new System.EventHandler(this.btnAccDel_Click);
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAccCancel.Location = new System.Drawing.Point(190, 17);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.Size = new System.Drawing.Size(75, 33);
            this.btnAccCancel.TabIndex = 1;
            this.btnAccCancel.Text = "Cancel";
            this.btnAccCancel.UseVisualStyleBackColor = true;
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // dataGridAccs
            // 
            this.dataGridAccs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surname,
            this.name,
            this.email});
            this.dataGridAccs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAccs.Location = new System.Drawing.Point(280, 0);
            this.dataGridAccs.Name = "dataGridAccs";
            this.dataGridAccs.Size = new System.Drawing.Size(342, 296);
            this.dataGridAccs.TabIndex = 1;
            this.dataGridAccs.Click += new System.EventHandler(this.dataGridAccs_Click);
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 296);
            this.Controls.Add(this.dataGridAccs);
            this.Controls.Add(this.groupBoxLeft);
            this.Name = "EditAccount";
            this.Text = "Edit an account";
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEditAcc.ResumeLayout(false);
            this.groupBoxEditAcc.PerformLayout();
            this.groupBoxBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxEditAcc;
        private System.Windows.Forms.TextBox txtBoxSearchAcc;
        private System.Windows.Forms.TextBox txtBoxAccEmail;
        private System.Windows.Forms.Label lblAccEmail;
        private System.Windows.Forms.TextBox txtBoxAccSur;
        private System.Windows.Forms.Label lblAccSur;
        private System.Windows.Forms.TextBox txtBoxAccName;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.Button btnAccCancel;
        private System.Windows.Forms.Button btnAccDel;
        private System.Windows.Forms.Button btnAccUpdate;
        private System.Windows.Forms.DataGridView dataGridAccs;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}