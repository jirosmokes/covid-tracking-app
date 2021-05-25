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
    public partial class Precautions : Form
    {
        public Precautions()
        {
            InitializeComponent();
        }

        private void Precautions_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cdc.gov/coronavirus/2019-ncov/prevent-getting-sick/prevention.html");
        }
    }
}
