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

namespace SHINKANSENAPP
{
    public partial class Signing : Form
    {
        public Signing()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            StreamWriter userinfo = new StreamWriter("userinfo.txt", true);
            userinfo.WriteLine(sgnuptextboxt1.Text);
            userinfo.WriteLine(sgnuptextboxt2.Text);
            MessageBox.Show("Your sign up details saved!", "Info Saved");
            sgnuptextboxt1.Text = sgnuptextboxt2.Text = string.Empty;
            sgnintextbox1.Focus();
            userinfo.Close();
           
        }
        

        private void signinbtn_Click(object sender, EventArgs e)
        {
            StreamReader userreadinfo = new StreamReader("userinfo.txt");
            if (userreadinfo.Peek() != -1)
            {
                string username = userreadinfo.ReadLine();
                string password = userreadinfo.ReadLine();

                bool firstreq = sgnintextbox1.Text.Contains(username);
                bool secondreq = sgnintextbox2.Text.Contains(password);
                if (firstreq && secondreq == true)
                {

                    userreadinfo.Close();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                }
            }
        }
    }
}
