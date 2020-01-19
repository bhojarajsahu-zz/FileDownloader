namespace FileDownloader
{
    partial class ViewDownloads
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
            this.dataGridViewDownloads = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDownloads)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDownloads
            // 
            this.dataGridViewDownloads.AllowUserToAddRows = false;
            this.dataGridViewDownloads.AllowUserToDeleteRows = false;
            this.dataGridViewDownloads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDownloads.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDownloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDownloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDownloads.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDownloads.Name = "dataGridViewDownloads";
            this.dataGridViewDownloads.ReadOnly = true;
            this.dataGridViewDownloads.Size = new System.Drawing.Size(549, 336);
            this.dataGridViewDownloads.TabIndex = 0;
            // 
            // ViewDownloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 336);
            this.Controls.Add(this.dataGridViewDownloads);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(565, 370);
            this.Name = "ViewDownloads";
            this.ShowInTaskbar = false;
            this.Text = "ViewDownloads";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewDownloads_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDownloads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDownloads;
    }
}