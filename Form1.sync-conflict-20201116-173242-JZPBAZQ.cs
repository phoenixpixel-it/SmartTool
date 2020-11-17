using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SmartTool
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage (IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture ();

        private void Form1_MouseDown (object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Close_btn_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click (object sender, EventArgs e)
        {
            FolderBrowserDialog aa = new FolderBrowserDialog();
            aa.ShowDialog();
            Path_txtbox.Text = aa.SelectedPath;
            lstfn1_lstbox.Items.Clear();
            string[] fileEntries = Directory.GetFiles(Path_txtbox.Text);
            foreach (string fileName in fileEntries)
                lstfn1_lstbox.Items.Add(fileName);
        }

        private void Start_fn1_btn_Click (object sender, EventArgs e)
        {
            
        }

        private void Path_txtbox_TextChanged (object sender, EventArgs e)
        {
            if (Path_txtbox.Text == "")
                Start_fn1_btn.Enabled = false;
            else
                Start_fn1_btn.Enabled = true;
        }
    }
}
