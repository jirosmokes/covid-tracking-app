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

    public partial class Inquiry : Form
    {
        public static bool btn = false;
        public static bool isChecked_1 = false;
        public static bool isChecked_2 = false;
        public static bool isChecked_3 = false;
        public static bool isChecked_4 = false;
        public static bool isChecked_5 = false;
        public static bool isChecked_6 = false;
        public static bool isChecked_7 = false;
        public static bool isChecked_8 = false;
        public static bool isChecked_9 = false;
        public static bool isChecked_10 = false;
        public static bool isChecked_11 = false;

        public Inquiry()
        {
            InitializeComponent();
        }

        //StreamWriter symptoms = new StreamWriter("symptoms.txt");
        StreamWriter userinff = new StreamWriter("userinfo.txt", true);
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "Fever") isChecked_1 = true;
            if (button.Text == "Dry Cough") isChecked_2 = true;
            if (button.Text == "Tiredness") isChecked_3 = true;
            if (button.Text == "Headaches") isChecked_4 = true;
            if (button.Text == "Sore Throat") isChecked_5 = true;
            if (button.Text == "No smell/taste") isChecked_6 = true;
            if (button.Text == "Rashes") isChecked_7 = true;
            if (button.Text == "Discolored nails") isChecked_8 = true;
            if (button.Text == "Breathing Issues") isChecked_9 = true;
            if (button.Text == "Chest Pains") isChecked_10 = true;
            if (button.Text == "Loss of Speech") isChecked_11 = true;

            userinff.WriteLine(button.Text);
            button.Enabled = false;
            button.BackColor = Color.Lime;
            btn = true;
    }

        //Save Button
        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "After submitting your data, you will \nno longer be able to modify\nyour submission.", "Notice",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answer == DialogResult.OK)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;               
                userinff.Close();
            }
            if (answer == DialogResult.Cancel);

            
        }

        private void Inquiry_Leave(object sender, EventArgs e)
        {
            userinff.Close();
        }

        private void Inquiry_Load(object sender, EventArgs e)
        {
            
        }
    }
}
