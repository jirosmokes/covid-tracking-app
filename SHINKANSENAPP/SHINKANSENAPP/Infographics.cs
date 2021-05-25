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
    public partial class Infographics : Form
    {

        public Infographics()
        {
            InitializeComponent();
        }

        private void Infographics_Load(object sender, EventArgs e)
        {
            //default geninfo loaded
            this.igloader.Controls.Clear();
            GenInfo fromgeninfoscreen = new GenInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fromgeninfoscreen.FormBorderStyle = FormBorderStyle.None;
            this.igloader.Controls.Add(fromgeninfoscreen);
            fromgeninfoscreen.Show();
            geninfo.BackColor = Color.SteelBlue;
            symptoms.BackColor = Color.Gainsboro;
            guidance.BackColor = Color.Gainsboro;

          
        }

        private void geninfo_Click(object sender, EventArgs e)
        {
            geninfo.BackColor = Color.SteelBlue;
            symptoms.BackColor = Color.Gainsboro;
            guidance.BackColor = Color.Gainsboro;

            this.igloader.Controls.Clear();
            GenInfo fromgeninfoscreen = new GenInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fromgeninfoscreen.FormBorderStyle = FormBorderStyle.None;
            this.igloader.Controls.Add(fromgeninfoscreen);
            fromgeninfoscreen.Show();
        }

        private void symptoms_Click(object sender, EventArgs e)
        {
            geninfo.BackColor = Color.Gainsboro;
            symptoms.BackColor = Color.SteelBlue;
            guidance.BackColor = Color.Gainsboro;

            this.igloader.Controls.Clear();
            Symptoms fromsymptomscreen = new Symptoms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fromsymptomscreen.FormBorderStyle = FormBorderStyle.None;
            this.igloader.Controls.Add(fromsymptomscreen);
            fromsymptomscreen.Show();

        }

        private void precaution_Click(object sender, EventArgs e)
        {
            geninfo.BackColor = Color.Gainsboro;
            symptoms.BackColor = Color.Gainsboro;
            guidance.BackColor = Color.SteelBlue;

            this.igloader.Controls.Clear();
            Precautions fromprecscreen = new Precautions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fromprecscreen.FormBorderStyle = FormBorderStyle.None;
            this.igloader.Controls.Add(fromprecscreen);
            fromprecscreen.Show();
        }

        private void igloader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
