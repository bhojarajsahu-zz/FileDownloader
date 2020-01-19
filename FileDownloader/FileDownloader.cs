using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDownloader
{
    delegate string DownloadFileDelegate(string location);
    public partial class FileDownloader : Form
    {
        List<string> statusList = null;
        string fileListLocation = @"D:\DownloadList.txt";

        public FileDownloader()
        {
            InitializeComponent();
        }

        private void FileDownloader_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            statusList = new List<string>();
            createFIleElseRead();
            this.Cursor = Cursors.Default;
        }

        public void createFIleElseRead()
        {
            try
            {
                dataGridViewList.Columns.Clear();
                dataGridViewList.Rows.Clear();
                dataGridViewList.Columns.Add("File List", "File List");

                if (!File.Exists(fileListLocation))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(fileListLocation))
                    {
                        sw.WriteLine("http://www.lazzycoder.com/");
                    }
                }

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(fileListLocation))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        dataGridViewList.Rows.Add(s);
                        //Console.WriteLine(s);
                    }
                }
            }
            catch { }
        }

        private void timerDownload_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                int res = now.Minute % 5;
                //                if (now.Minute.ToString() == "30" || now.Minute.ToString() == "00")
                if (res.ToString() == "0")
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        string fileLocation = string.Empty;
                        foreach (DataGridViewRow row in dataGridViewList.Rows)
                        {
                            DownloadFileDelegate newDD = DownloadFile;
                            fileLocation = Convert.ToString(row.Cells[0].Value);
                            DownloadFile(fileLocation);
                            IAsyncResult asyncResult = newDD.BeginInvoke(fileLocation, null, null);
                            string callBackResult = newDD.EndInvoke(asyncResult);

                        }

                    }
                    catch { }
                }
            }
            catch { }
        }
        public string DownloadFile(string url)
        {
            //this.Cursor = Cursors.WaitCursor;
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers["User-Agent"] =
                    "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
                    "(compatible; MSIE 6.0; Windows NT 5.1; " +
                    ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";

                    // Download data.
                    byte[] arr = client.DownloadData(url);
                    statusList.Add(DateTime.Now.ToString() + "|" + url + " | Success");
                    //// Write values.
                    //Console.WriteLine("--- WebClient result ---");
                    //Console.WriteLine(arr.Length);
                    return "";
                }
            }
            catch
            {
                statusList.Add(DateTime.Now.ToString() + "|" + url + " | Failed");
                return "";
            }
            //this.Cursor = Cursors.Default;
        }
        //public void DownloadFile()
        //{
        //    this.Cursor = Cursors.WaitCursor;
        //    string fileLocation = string.Empty;
        //    try
        //    {
        //        foreach (DataGridViewRow row in dataGridViewList.Rows)
        //        {
        //            fileLocation = Convert.ToString(row.Cells[0].Value);
        //            using (WebClient client = new WebClient())
        //            {
        //                client.Headers["User-Agent"] =
        //                "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
        //                "(compatible; MSIE 6.0; Windows NT 5.1; " +
        //                ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";

        //                // Download data.
        //                byte[] arr = client.DownloadData(fileLocation);
        //                statusList.Add(DateTime.Now.ToString() + "|" + fileLocation + " | Success");
        //                //// Write values.
        //                //Console.WriteLine("--- WebClient result ---");
        //                //Console.WriteLine(arr.Length);
        //            }

        //        }
        //    }
        //    catch
        //    {
        //        statusList.Add(DateTime.Now.ToString() + "|" + fileLocation + " | Failed");
        //    }
        //    this.Cursor = Cursors.Default;
        //}

        public bool CheckURLValid(string source)
        {
            try
            {
                //Uri uriResult;
                //return Uri.TryCreate(source, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp;
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (!string.IsNullOrEmpty(textBoxFileLoc.Text))
            {
                if (CheckURLValid(textBoxFileLoc.Text))
                {
                    using (StreamWriter writer =
                        new StreamWriter(fileListLocation, true))
                    {
                        writer.WriteLine(textBoxFileLoc.Text);
                    }

                    dataGridViewList.Rows.Add(textBoxFileLoc.Text);
                    textBoxFileLoc.Text = "";
                }
                else
                    MessageBox.Show("Please enter a valid address.");
            }
            else
                MessageBox.Show("Please enter a valid address.");

            this.Cursor = Cursors.Default;
        }

        private void FileDownloader_Resize(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIconDownload.ShowBalloonTip(1000);
                this.Hide();

            }
            this.Cursor = Cursors.Default;
        }

        private void notifyIconDownload_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            catch { }
            this.Cursor = Cursors.Default;
        }

        private void checkBoxViewDownload_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (checkBoxViewDownload.Checked)
            {
                ViewDownloads newDownloads = new ViewDownloads();
                newDownloads.setData(statusList);
                newDownloads.Show();
                checkBoxViewDownload.Checked = false;
            }
            this.Cursor = Cursors.Default;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteLine(dataGridViewList.SelectedRows[0].Cells[0].Value.ToString()))
                    dataGridViewList.Rows.Remove(dataGridViewList.SelectedRows[0]);
                else
                    MessageBox.Show("Access denied.");
                //dataGridViewList
            }
            catch { }

        }
        public bool deleteLine(string lineToDelete)
        {
            bool status = false;
            try
            {
                var file = new List<string>(System.IO.File.ReadAllLines(fileListLocation));
                file.Remove(lineToDelete);
                File.WriteAllLines(fileListLocation, file.ToArray());
                status = true;
            }
            catch
            {
                status = false;
            }
            return status;
        }

        private void dataGridViewList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxSelected.Text = dataGridViewList.SelectedRows[0].Cells[0].Value.ToString();
                buttonRemove.Enabled = true;
            }
            catch { }
        }
    }
}
