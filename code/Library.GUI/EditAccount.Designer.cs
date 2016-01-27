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
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.dataGridAccount = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxAccSearch = new System.Windows.Forms.TextBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxAccName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.textBoxAccSur = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxAccEmail = new System.Windows.Forms.TextBox();
            this.groupBoxBtn = new System.Windows.Forms.GroupBox();
            this.btnAccUpdate = new System.Windows.Forms.Button();
            this.btnAccDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBoxRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccount)).BeginInit();
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxBtn.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.dataGridAccount);
            this.groupBoxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxRight.Location = new System.Drawing.Point(309, 0);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(351, 309);
            this.groupBoxRight.TabIndex = 0;
            this.groupBoxRight.TabStop = false;
            // 
            // dataGridAccount
            // 
            this.dataGridAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname,
            this.email});
            this.dataGridAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAccount.Location = new System.Drawing.Point(3, 16);
            this.dataGridAccount.Name = "dataGridAccount";
            this.dataGridAccount.Size = new System.Drawing.Size(345, 290);
            this.dataGridAccount.TabIndex = 0;
            this.dataGridAccount.Click += new System.EventHandler(this.dataGridAccount_Click);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
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
            this.groupBoxLeft.Size = new System.Drawing.Size(303, 309);
            this.groupBoxLeft.TabIndex = 1;
            this.groupBoxLeft.TabStop = false;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxAccSearch);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSearch.Location = new System.Drawing.Point(3, 16);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(297, 43);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search:";
            // 
            // textBoxAccSearch
            // 
            this.textBoxAccSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAccSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAccSearch.Location = new System.Drawing.Point(3, 17);
            this.textBoxAccSearch.Name = "textBoxAccSearch";
            this.textBoxAccSearch.Size = new System.Drawing.Size(291, 21);
            this.textBoxAccSearch.TabIndex = 0;
            this.textBoxAccSearch.TextChanged += new System.EventHandler(this.textBoxAccSearch_TextChanged);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.textBoxAccEmail);
            this.groupBoxEdit.Controls.Add(this.lblEmail);
            this.groupBoxEdit.Controls.Add(this.textBoxAccSur);
            this.groupBoxEdit.Controls.Add(this.lblSurname);
            this.groupBoxEdit.Controls.Add(this.textBoxAccName);
            this.groupBoxEdit.Controls.Add(this.lblName);
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEdit.Location = new System.Drawing.Point(3, 59);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(297, 144);
            this.groupBoxEdit.TabIndex = 1;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(3, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // textBoxAccName
            // 
            this.textBoxAccName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAccName.Location = new System.Drawing.Point(3, 32);
            this.textBoxAccName.Name = "textBoxAccName";
            this.textBoxAccName.Size = new System.Drawing.Size(291, 21);
            this.textBoxAccName.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurname.Location = new System.Drawing.Point(3, 53);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 15);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // textBoxAccSur
            // 
            this.textBoxAccSur.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAccSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAccSur.Location = new System.Drawing.Point(3, 68);
            this.textBoxAccSur.Name = "textBoxAccSur";
            this.textBoxAccSur.Size = new System.Drawing.Size(291, 21);
            this.textBoxAccSur.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmail.Location = new System.Drawing.Point(3, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // textBoxAccEmail
            // 
            this.textBoxAccEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAccEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAccEmail.Location = new System.Drawing.Point(3, 104);
            this.textBoxAccEmail.Name = "textBoxAccEmail";
            this.textBoxAccEmail.Size = new System.Drawing.Size(291, 21);
            this.textBoxAccEmail.TabIndex = 5;
            // 
            // groupBoxBtn
            // 
            this.groupBoxBtn.Controls.Add(this.btnCancel);
            this.groupBoxBtn.Controls.Add(this.btnAccDel);
            this.groupBoxBtn.Controls.Add(this.btnAccUpdate);
            this.groupBoxBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBtn.Location = new System.Drawing.Point(3, 223);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(297, 48);
            this.groupBoxBtn.TabIndex = 2;
            this.groupBoxBtn.TabStop = false;
            // 
            // btnAccUpdate
            // 
            this.btnAccUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccUpdate.Location = new System.Drawing.Point(3, 17);
            this.btnAccUpdate.Name = "btnAccUpdate";
            this.btnAccUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnAccUpdate.TabIndex = 0;
            this.btnAccUpdate.Text = "Update";
            this.btnAccUpdate.UseVisualStyleBackColor = true;
            this.btnAccUpdate.Click += new System.EventHandler(this.btnAccUpdate_Click);
            // 
            // btnAccDel
            // 
            this.btnAccDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccDel.Location = new System.Drawing.Point(78, 17);
            this.btnAccDel.Name = "btnAccDel";
            this.btnAccDel.Size = new System.Drawing.Size(75, 28);
            this.btnAccDel.TabIndex = 1;
            this.btnAccDel.Text = "Delete";
            this.btnAccDel.UseVisualStyleBackColor = true;
            this.btnAccDel.Click += new System.EventHandler(this.btnAccDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(219, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.lblMsg);
            this.groupBoxMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMsg.Location = new System.Drawing.Point(3, 271);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(297, 35);
            this.groupBoxMsg.TabIndex = 3;
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
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 309);
            this.Controls.Add(this.groupBoxLeft);
            this.Controls.Add(this.groupBoxRight);
            this.Name = "EditAccount";
            this.Text = "Edit accounts";
            this.groupBoxRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccount)).EndInit();
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxBtn.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBoxMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.DataGridView dataGridAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxAccSearch;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccDel;
        private System.Windows.Forms.Button btnAccUpdate;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.TextBox textBoxAccEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxAccSur;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox textBoxAccName;
        private System.Windows.Forms.Label lblName;
    }
}