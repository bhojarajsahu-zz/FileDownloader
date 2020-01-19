using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDownloader
{
    public partial class ViewDownloads : Form
    {
        List<string> downloadList = null;
        public ViewDownloads()
        {
            InitializeComponent();
        }
        public void setData(List<string> downloadLst)
        {
            downloadList = new List<string>();
            downloadList = downloadLst;
        }
        private void ViewDownloads_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            this.Cursor = Cursors.WaitCursor;
            int counter = 1;
            dataGridViewDownloads.Rows.Clear();
            dataGridViewDownloads.Columns.Clear();
            dataGridViewDownloads.Columns.Add("Counter", "Counter");
            dataGridViewDownloads.Columns.Add("Time", "Time");
            dataGridViewDownloads.Columns.Add("URL", "URL");
            dataGridViewDownloads.Columns.Add("Status", "Status");
            foreach (string item in downloadList)
            {
                string[] downStat = item.Split('|');
                dataGridViewDownloads.Rows.Add(counter, downStat[0], downStat[1], downStat[2]);
                counter++;
            }
            this.Cursor = Cursors.Default;
        }
    }
}
