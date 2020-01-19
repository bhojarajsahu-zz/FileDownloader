namespace FileDownloader
{
    partial class FileDownloader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileDownloader));
            this.groupBoxAddNew = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxFileLoc = new System.Windows.Forms.TextBox();
            this.labelFileLoc = new System.Windows.Forms.Label();
            this.groupBoxDownloadList = new System.Windows.Forms.GroupBox();
            this.checkBoxViewDownload = new System.Windows.Forms.CheckBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.timerDownload = new System.Windows.Forms.Timer(this.components);
            this.notifyIconDownload = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBoxSelected = new System.Windows.Forms.TextBox();
            this.labelSelected = new System.Windows.Forms.Label();
            this.groupBoxAddNew.SuspendLayout();
            this.groupBoxDownloadList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddNew
            // 
            this.groupBoxAddNew.Controls.Add(this.buttonAdd);
            this.groupBoxAddNew.Controls.Add(this.textBoxFileLoc);
            this.groupBoxAddNew.Controls.Add(this.labelFileLoc);
            this.groupBoxAddNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAddNew.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAddNew.Name = "groupBoxAddNew";
            this.groupBoxAddNew.Size = new System.Drawing.Size(849, 55);
            this.groupBoxAddNew.TabIndex = 0;
            this.groupBoxAddNew.TabStop = false;
            this.groupBoxAddNew.Text = "Add New";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(752, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxFileLoc
            // 
            this.textBoxFileLoc.Location = new System.Drawing.Point(80, 22);
            this.textBoxFileLoc.Name = "textBoxFileLoc";
            this.textBoxFileLoc.Size = new System.Drawing.Size(654, 20);
            this.textBoxFileLoc.TabIndex = 1;
            // 
            // labelFileLoc
            // 
            this.labelFileLoc.AutoSize = true;
            this.labelFileLoc.Location = new System.Drawing.Point(23, 25);
            this.labelFileLoc.Name = "labelFileLoc";
            this.labelFileLoc.Size = new System.Drawing.Size(51, 13);
            this.labelFileLoc.TabIndex = 0;
            this.labelFileLoc.Text = "Location:";
            // 
            // groupBoxDownloadList
            // 
            this.groupBoxDownloadList.Controls.Add(this.textBoxSelected);
            this.groupBoxDownloadList.Controls.Add(this.labelSelected);
            this.groupBoxDownloadList.Controls.Add(this.checkBoxViewDownload);
            this.groupBoxDownloadList.Controls.Add(this.dataGridViewList);
            this.groupBoxDownloadList.Controls.Add(this.buttonRemove);
            this.groupBoxDownloadList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDownloadList.Location = new System.Drawing.Point(0, 55);
            this.groupBoxDownloadList.Name = "groupBoxDownloadList";
            this.groupBoxDownloadList.Size = new System.Drawing.Size(849, 382);
            this.groupBoxDownloadList.TabIndex = 1;
            this.groupBoxDownloadList.TabStop = false;
            this.groupBoxDownloadList.Text = "Download Links";
            // 
            // checkBoxViewDownload
            // 
            this.checkBoxViewDownload.AutoSize = true;
            this.checkBoxViewDownload.Location = new System.Drawing.Point(80, 19);
            this.checkBoxViewDownload.Name = "checkBoxViewDownload";
            this.checkBoxViewDownload.Size = new System.Drawing.Size(105, 17);
            this.checkBoxViewDownload.TabIndex = 4;
            this.checkBoxViewDownload.Text = "View Downloads";
            this.checkBoxViewDownload.UseVisualStyleBackColor = true;
            this.checkBoxViewDownload.CheckedChanged += new System.EventHandler(this.checkBoxViewDownload_CheckedChanged);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewList.Location = new System.Drawing.Point(3, 75);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(843, 304);
            this.dataGridViewList.TabIndex = 3;
            this.dataGridViewList.SelectionChanged += new System.EventHandler(this.dataGridViewList_SelectionChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(752, 19);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // timerDownload
            // 
            this.timerDownload.Enabled = true;
            this.timerDownload.Interval = 50000;
            this.timerDownload.Tick += new System.EventHandler(this.timerDownload_Tick);
            // 
            // notifyIconDownload
            // 
            this.notifyIconDownload.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconDownload.BalloonTipText = "Download In Progress";
            this.notifyIconDownload.BalloonTipTitle = "Status";
            this.notifyIconDownload.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDownload.Icon")));
            this.notifyIconDownload.Text = "Download In Progress";
            this.notifyIconDownload.Visible = true;
            this.notifyIconDownload.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconDownload_MouseDoubleClick);
            // 
            // textBoxSelected
            // 
            this.textBoxSelected.Location = new System.Drawing.Point(80, 49);
            this.textBoxSelected.Name = "textBoxSelected";
            this.textBoxSelected.ReadOnly = true;
            this.textBoxSelected.Size = new System.Drawing.Size(654, 20);
            this.textBoxSelected.TabIndex = 6;
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(23, 52);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(52, 13);
            this.labelSelected.TabIndex = 5;
            this.labelSelected.Text = "Selected:";
            // 
            // FileDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 437);
            this.Controls.Add(this.groupBoxDownloadList);
            this.Controls.Add(this.groupBoxAddNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(865, 475);
            this.MinimumSize = new System.Drawing.Size(865, 475);
            this.Name = "FileDownloader";
            this.Text = "Silent Download List";
            this.Load += new System.EventHandler(this.FileDownloader_Load);
            this.Resize += new System.EventHandler(this.FileDownloader_Resize);
            this.groupBoxAddNew.ResumeLayout(false);
            this.groupBoxAddNew.PerformLayout();
            this.groupBoxDownloadList.ResumeLayout(false);
            this.groupBoxDownloadList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddNew;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxFileLoc;
        private System.Windows.Forms.Label labelFileLoc;
        private System.Windows.Forms.GroupBox groupBoxDownloadList;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Timer timerDownload;
        private System.Windows.Forms.NotifyIcon notifyIconDownload;
        private System.Windows.Forms.CheckBox checkBoxViewDownload;
        private System.Windows.Forms.TextBox textBoxSelected;
        private System.Windows.Forms.Label labelSelected;

    }
}

