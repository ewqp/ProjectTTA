namespace Library.GUI
{
    partial class ShowHistory
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
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.dataGridHistory = new System.Windows.Forms.DataGridView();
            this.accountSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchLog = new System.Windows.Forms.Label();
            this.textBoxSearchLog = new System.Windows.Forms.TextBox();
            this.groupBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.dataGridHistory);
            this.groupBoxLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxLog.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(752, 271);
            this.groupBoxLog.TabIndex = 0;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "History log";
            // 
            // dataGridHistory
            // 
            this.dataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountSurname,
            this.bookTitle,
            this.bookAuthor,
            this.histDate,
            this.status});
            this.dataGridHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHistory.Location = new System.Drawing.Point(3, 17);
            this.dataGridHistory.Name = "dataGridHistory";
            this.dataGridHistory.Size = new System.Drawing.Size(746, 251);
            this.dataGridHistory.TabIndex = 0;
            // 
            // accountSurname
            // 
            this.accountSurname.Frozen = true;
            this.accountSurname.HeaderText = "Account";
            this.accountSurname.Name = "accountSurname";
            // 
            // bookTitle
            // 
            this.bookTitle.Frozen = true;
            this.bookTitle.HeaderText = "Title";
            this.bookTitle.Name = "bookTitle";
            // 
            // bookAuthor
            // 
            this.bookAuthor.Frozen = true;
            this.bookAuthor.HeaderText = "Author";
            this.bookAuthor.Name = "bookAuthor";
            // 
            // histDate
            // 
            this.histDate.Frozen = true;
            this.histDate.HeaderText = "Date";
            this.histDate.Name = "histDate";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblSearchLog
            // 
            this.lblSearchLog.AutoSize = true;
            this.lblSearchLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearchLog.Location = new System.Drawing.Point(0, 271);
            this.lblSearchLog.Name = "lblSearchLog";
            this.lblSearchLog.Size = new System.Drawing.Size(113, 15);
            this.lblSearchLog.TabIndex = 1;
            this.lblSearchLog.Text = "Search for a log:";
            // 
            // textBoxSearchLog
            // 
            this.textBoxSearchLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchLog.Location = new System.Drawing.Point(0, 286);
            this.textBoxSearchLog.Name = "textBoxSearchLog";
            this.textBoxSearchLog.Size = new System.Drawing.Size(752, 20);
            this.textBoxSearchLog.TabIndex = 2;
            this.textBoxSearchLog.TextChanged += new System.EventHandler(this.textBoxSearchLog_TextChanged);
            // 
            // ShowHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 327);
            this.Controls.Add(this.textBoxSearchLog);
            this.Controls.Add(this.lblSearchLog);
            this.Controls.Add(this.groupBoxLog);
            this.Name = "ShowHistory";
            this.Text = "Show Library log";
            this.groupBoxLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.DataGridView dataGridHistory;
        private System.Windows.Forms.Label lblSearchLog;
        private System.Windows.Forms.TextBox textBoxSearchLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn histDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}