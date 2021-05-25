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
    public partial class Homescreen : Form
    {

        bool emptyText_0 = true;
        bool emptyText_1 = true;
        bool emptyText_2 = true;
        bool emptyText_3 = true;
        bool emptyText_4 = true;
        int progress = 0;
        DataTable table;
        StreamWriter personalinfo = new StreamWriter("userinfo.txt", true);

        public Homescreen()
        {
            InitializeComponent();
            timelabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void Homescreen_Load(object sender, EventArgs e)
        {

            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Notes", typeof(String));
            dataGridView1.DataSource = table;
            personalinfo.WriteLine(nameTextBox.Text);
            dataGridView1.Columns["Notes"].Visible = false;
            dataGridView1.Columns["Title"].Width = 570;

            radioButton1.AutoCheck = true;
        }

        private void timenow_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToLongTimeString();
            timenow.Start();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                emptyText_0 = true;
                progress -= 20;
            }
            else if (emptyText_0)
            {
                emptyText_0 = false;
                progress += 20;
            }
            label10.Text = progress.ToString() + "%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                emptyText_4 = true;
                progress -= 20;
            }
            else if (emptyText_4)
            {
                emptyText_4 = false;
                progress += 20;
            }
            label10.Text = progress.ToString() + "%";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//age
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                emptyText_1 = true;
                progress -= 10;
            }
            else if (emptyText_1)
            {
                emptyText_1 = false;
                progress += 10;
            }
            label10.Text = progress.ToString() + "%";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//female
        {
            if (!radioButton5.Checked) progress += 5;
            else progress -= 5;
            label10.Text = progress.ToString() + "%";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)//male
        {
            if (!radioButton4.Checked) progress += 10;
            else progress -= 5;
            label10.Text = progress.ToString() + "%";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//student
        {
            if (!radioButton3.Checked && !radioButton2.Checked) progress += 5;
            else progress -= 5;
            label10.Text = progress.ToString() + "%";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//employee
        {
            if (!radioButton1.Checked && !radioButton3.Checked) progress += 5;
            else progress -= 5;
            label10.Text = progress.ToString() + "%";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked) progress += 5;
            else progress -= 5;
            label10.Text = progress.ToString() + "%";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//email
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                emptyText_2 = true;
                progress -= 20;
            }
            else if (emptyText_2)
            {
                emptyText_2 = false;
                progress += 20;
            }
            label10.Text = progress.ToString() + "%";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//contact num
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                emptyText_3 = true;
                progress -= 20;
            }
            else if (emptyText_3)
            {
                emptyText_3 = false;
                progress += 20;
            }
            label10.Text = progress.ToString() + "%";

        }

        private void button1_Click(object sender, EventArgs e)//read
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                nameTextBox.Text = table.Rows[index].ItemArray[0].ToString();
                msgTextBox.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
            nameTextBox.Clear();
            msgTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)//new
        {
            nameTextBox.Clear();
            msgTextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)//save
        {
            table.Rows.Add(nameTextBox.Text, msgTextBox.Text);
            nameTextBox.Clear();
            msgTextBox.Clear();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (progress != 100)
            {
                MessageBox.Show("The form is not complete.\nMake sure all boxes are filled in\nbefore saving.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult answer = MessageBox.Show(
                "After submitting your data, you will \nno longer be able to modify\nyour submission.", "Notice",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.OK)
                {
                    //disabling all buttons
                    {
                        textBox2.Enabled = false;
                        radioButton1.Enabled = false;
                        radioButton2.Enabled = false;
                        radioButton3.Enabled = false;
                        radioButton4.Enabled = false;
                        radioButton5.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        bunifuFlatButton1.Enabled = false;
                    }
                    personalinfo.WriteLine(textBox2.Text);
                    if (radioButton4.Checked)
                    {
                        personalinfo.WriteLine("Male");
                    }
                    else if (radioButton5.Checked)
                    {
                        personalinfo.WriteLine("Female");
                    }

                    if (radioButton1.Checked)
                    {
                        personalinfo.WriteLine("Student");
                    }
                    else if (radioButton2.Checked)
                    {
                        personalinfo.WriteLine("Employee");
                    }
                    else if (radioButton4.Checked)
                    {
                        personalinfo.WriteLine("Senior Citizen");
                    }

                    personalinfo.WriteLine(textBox3.Text);
                    personalinfo.WriteLine(textBox4.Text);

                    personalinfo.Close();
                }
            }

        }

        private void Homescreen_Leave(object sender, EventArgs e)
        {
            personalinfo.Close();
        }

        
    }
}
