using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribution_Managment_System
{
    public partial class GenerateRouteWindow : Form
    {
        public GenerateRouteWindow()
        {
            InitializeComponent();
            
            region_combox.SelectedIndex = 1;
            //checkBox1.Checked = true;
        }

        private void show_map_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void GenerateRouteWindow_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] types = new string[] { "m", "k", "h", "p", "e" };
            string url = string.Format("http://maps.google.com/maps?t={0}&q=loc:{1}",
                types[region_combox.SelectedIndex]);
            //if (checkBox1.Checked)
            //    url = string.Format("http://maps.google.com/maps?t={0}&q=loc:{1},{2}",
            //        types[map_type.SelectedIndex], lat.Text, lon.Text);
            webBrowser1.Navigate(url);
        }
    }
}
