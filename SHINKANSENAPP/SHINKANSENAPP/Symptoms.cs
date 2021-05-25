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
    public partial class Symptoms : Form
    {
        public Symptoms()
        {
            InitializeComponent();
        }

        private void Symptoms_Load(object sender, EventArgs e)
        {
            if (Inquiry.btn == true) button15.Visible = true;

            //Fever
            if (Inquiry.isChecked_1 == true) button1.BackColor = Color.Lime;
            //Dry Cough
            if (Inquiry.isChecked_2 == true) button2.BackColor = Color.Lime;
            //Tiredness
            if (Inquiry.isChecked_3 == true) button3.BackColor = Color.Lime;

            //Headaches
            if (Inquiry.isChecked_4 == true) button4.BackColor = Color.Lime;
            //Sore Throat
            if (Inquiry.isChecked_5 == true) button5.BackColor = Color.Lime;
            //No Smell/Taste
            if (Inquiry.isChecked_6 == true) button6.BackColor = Color.Lime;
            //Rashes
            if (Inquiry.isChecked_7 == true) button7.BackColor = Color.Lime;
            //Discolored Nails
            if (Inquiry.isChecked_8 == true) button8.BackColor = Color.Lime;

            //Breathing Issues
            if (Inquiry.isChecked_9 == true) button9.BackColor = Color.Lime;
            //Chest Pains
            if (Inquiry.isChecked_10 == true) button10.BackColor = Color.Lime;
            //Loss of Speech
            if (Inquiry.isChecked_11 == true) button11.BackColor = Color.Lime;
        }

        //Common symptoms advice
        private void button12_MouseEnter(object sender, EventArgs e)
        {
            AdviceBox.Text = "    If you are a healthy individual with Common symptoms, you should be\n" +
                "able to manage staying at home committing self-quarantine.\n\n" +
                "Otherwise, if you have underlying health conditions or are beginning\n" +
                "to develop serious symptoms,\n" +
                "Please seek a medical professional for further consultation";
        }
        private void button12_MouseLeave(object sender, EventArgs e)
        {
            AdviceBox.Text = "";
        }

        //Serious symptoms advice
        private void button13_MouseEnter(object sender, EventArgs e)
        {
            AdviceBox.Text = "      Seek immediate medical attention\n" +
                "as soon as possible.\n\n" +
                "This is especially urgent if you have any\n" +
                "underlying health conditions.\n" +
                "Ensure to practice mandatory self-quarantine as much as possible.";
        }
        private void button13_MouseLeave(object sender, EventArgs e)
        {
            AdviceBox.Text = "";
        }

        //Time for symptoms
        private void button14_MouseEnter(object sender, EventArgs e)
        {
            AdviceBox.Text = "    Upon infection, it may take 5-6 days\n" +
                "before any symptoms show.\n" +
                "However, some cases have had symptoms emerging" +
                "after up to 14 days.";
        }
        private void button14_MouseLeave(object sender, EventArgs e)
        {
            AdviceBox.Text = "";
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            AdviceBox.Text = "    Based on your answers in the\n" +
                "Inquiry page, symptoms with\n" +
                "green boxes are meant to\n" +
                "show the symptoms you are\n" +
                "currently enduring and its severity";
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            AdviceBox.Text = "";
        }

    }
}
