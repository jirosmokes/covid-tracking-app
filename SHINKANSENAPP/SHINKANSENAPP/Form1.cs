using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHINKANSENAPP
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
            highlights.Height = homebtn.Height;
            highlights.Top = homebtn.Top;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void homebtn_Click_1(object sender, EventArgs e)
        {
            highlights.Height = homebtn.Height;
            highlights.Top = homebtn.Top;


            this.formloader.Controls.Clear();
            Homescreen fromhomescreen = new Homescreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fromhomescreen.FormBorderStyle = FormBorderStyle.None;
            this.formloader.Controls.Add(fromhomescreen);
            fromhomescreen.Show();
        }

        private void inquirybtn_Click_1(object sender, EventArgs e)
        {
            highlights.Height = inquirybtn.Height;
            highlights.Top = inquirybtn.Top;

            this.formloader.Controls.Clear();
            Inquiry frominqryscreen = new Inquiry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frominqryscreen.FormBorderStyle = FormBorderStyle.None;
            this.formloader.Controls.Add(frominqryscreen);
            frominqryscreen.Show();
        }

        private void reportsbtn_Click_1(object sender, EventArgs e)
        {
            highlights.Height = reportsbtn.Height;
            highlights.Top = reportsbtn.Top;

            this.formloader.Controls.Clear();
            Reports fromreportsscreen = new Reports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fromreportsscreen.FormBorderStyle = FormBorderStyle.None;
            this.formloader.Controls.Add(fromreportsscreen);
            fromreportsscreen.Show();
        }

        private void infogbtn_Click_1(object sender, EventArgs e)
        {
            highlights.Height = infogbtn.Height;
            highlights.Top = infogbtn.Top;

            this.formloader.Controls.Clear();
            Infographics frominfographicscreen = new Infographics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frominfographicscreen.FormBorderStyle = FormBorderStyle.None;
            this.formloader.Controls.Add(frominfographicscreen);
            frominfographicscreen.Show();
        }

        private void aboutbtn_Click_1(object sender, EventArgs e)
        {
            highlights.Height = aboutbtn.Height;
            highlights.Top = aboutbtn.Top;


            this.formloader.Controls.Clear();
            About fromaboutscreen = new About() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fromaboutscreen.FormBorderStyle = FormBorderStyle.None;
            this.formloader.Controls.Add(fromaboutscreen);
            fromaboutscreen.Show();
        }
    }
}
