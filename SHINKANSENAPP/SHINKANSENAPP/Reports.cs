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
using System.Net;

namespace SHINKANSENAPP
{
    public partial class Reports : Form
    {
        bool isweeklypressed = false;
        bool ismonthlypressed = false;
        
        public Reports()
        {
            InitializeComponent();
            weeklybtn.Enabled = false;
            monthlybtn.Enabled = false;
            ismonthlypressed = false;
            isweeklypressed = false;
        }

        
        
        private void Reports_Load(object sender, EventArgs e)
        {
           
         
          

        }
        StreamReader casesweeklyreport = new StreamReader("weekly.txt");
        StreamReader recoveryweeklyreport = new StreamReader("weeklyvaccinates.txt");

        private void showGraph()
        {
            if (isweeklypressed)
            {
                if (casesbtn.Checked)
                {
                    chart1.BringToFront();

                    while (casesweeklyreport.Peek() != -1)
                    {
                        string full = casesweeklyreport.ReadLine();
                        string[] half = full.Split(',');

                        string date = half[0];
                        string totalnewcase = half[1];
                        string totalnewdeath = half[2];

                        chart1.Series["COVID Cases"].Points.AddXY(date, totalnewcase);
                        chart1.Series["COVID Deaths"].Points.AddXY(date, totalnewdeath);
                    }
                    if (isweeklypressed == true)
                    {
                        comboBox1.Items.Clear();
                        StreamReader casesweeklyreport = new StreamReader("weekly.txt");
                        while (casesweeklyreport.Peek() != -1)
                        {
                            string full = casesweeklyreport.ReadLine();
                            string[] half = full.Split(',');

                            string date = half[0];

                            comboBox1.Items.AddRange(date.Split(','));
                        }
                    }// CASES WEEKLY CONDITION
                }
                else if (recoveriesbtn.Checked)
                {

                    chart3.BringToFront();
                    while (recoveryweeklyreport.Peek() != -1)
                    {
                        string full = recoveryweeklyreport.ReadLine();
                        string[] half = full.Split(',');

                        string date = half[0];
                        string firstvaccinated = half[1];
                        string totalfaccinated = half[2];

                        chart3.Series["First Vaccine"].Points.AddXY(date, firstvaccinated);
                        chart3.Series["Fully Vaccinated"].Points.AddXY(date, totalfaccinated);
                    }
                    if (isweeklypressed == true)
                    {
                        comboBox1.Items.Clear();
                        StreamReader casesweeklyreport = new StreamReader("weeklyvaccinates.txt");
                        while (casesweeklyreport.Peek() != -1)
                        {
                            string full = casesweeklyreport.ReadLine();
                            string[] half = full.Split(',');

                            string date = half[0];

                            comboBox1.Items.AddRange(date.Split(','));
                        }
                    } //RECOVERIES WEEKLY CONDITION
                }
            }
            if (ismonthlypressed)
            {
                if (casesbtn.Checked)
                {
                    chart2.BringToFront();
                    while (monthlyreport.Peek() != -1)
                    {
                        string full = monthlyreport.ReadLine();
                        string[] half = full.Split(',');

                        string date = half[0];
                        string totalnewcase = half[1];
                        string totalnewdeath = half[2];

                        chart2.Series["COVID Cases"].Points.AddXY(date, totalnewcase);
                        chart2.Series["COVID Deaths"].Points.AddXY(date, totalnewdeath);
                    }
                    if (ismonthlypressed == true)
                    {
                        comboBox1.Items.Clear();
                        StreamReader casesmonthlyreport = new StreamReader("monthly.txt");
                        while (casesmonthlyreport.Peek() != -1)
                        {
                            string full = casesmonthlyreport.ReadLine();
                            string[] half = full.Split(',');

                            string date = half[0];

                            comboBox1.Items.AddRange(date.Split(','));
                        }
                    }// CASES MONTHLY CONDITION

                }
                else if (recoveriesbtn.Checked)
                {
                    chart4.BringToFront();
                    while (recoverymonthlyreport.Peek() != -1)
                    {
                        string full = recoverymonthlyreport.ReadLine();
                        string[] half = full.Split(',');

                        string date = half[0];
                        string firstvaccinated = half[1];
                        string totalfaccinated = half[2];

                        chart4.Series["First Vaccine"].Points.AddXY(date, firstvaccinated);
                        chart4.Series["Fully Vaccinated"].Points.AddXY(date, totalfaccinated);
                    }
                    if (ismonthlypressed == true)
                    {
                        comboBox1.Items.Clear();
                        StreamReader recoverymonthlyreport = new StreamReader("monthlyvaccinates.txt");
                        while (recoverymonthlyreport.Peek() != -1)
                        {
                            string full = recoverymonthlyreport.ReadLine();
                            string[] half = full.Split(',');

                            string date = half[0];

                            comboBox1.Items.AddRange(date.Split(','));
                        }
                    }// RECOVERIES MONTHLY CONDITION

                }
            }
        }

        private void weeklybtn_Click(object sender, EventArgs e)
        {
            ismonthlypressed = false;
            isweeklypressed = true;
            showGraph();

            weeklybtn.BackColor = Color.SteelBlue;
            monthlybtn.BackColor = Color.Gainsboro;

        }
        StreamReader monthlyreport = new StreamReader("monthly.txt");
        StreamReader recoverymonthlyreport = new StreamReader("monthlyvaccinates.txt");
        private void monthlybtn_Click(object sender, EventArgs e)
        {
            isweeklypressed = false;
            ismonthlypressed = true;

            showGraph();
            monthlybtn.BackColor = Color.SteelBlue;
            weeklybtn.BackColor = Color.Gainsboro;
        }

        private void casesbtn_Click(object sender, EventArgs e)
        {
            StreamReader covidcases = new StreamReader("countrycasesdeaths.txt");
           
                listView1.BringToFront();
                listView2.SendToBack();
                while (covidcases.Peek() != -1)
                {
                    string full = covidcases.ReadLine();
                    string[] half = full.Split(',');
                    string[,] data = { { half[0], half[1], half[2] } };
                    int firstcolumn = data.GetLength(0);
                    for (int i = 0; i < firstcolumn; i++)
                    {
                        ListViewItem lists = new ListViewItem(data[i, 0]);
                        listView1.Items.Add(lists);
                        lists.SubItems.Add(data[i, 1]);
                        lists.SubItems.Add(data[i, 2]);
                    }
                }
                int numberofrows = listView1.Items.Count;
                for (int i = 0; i < numberofrows; i++)
                {
                    if (listView1.Items[i].Index % 2 == 0)
                    {
                        listView1.Items[i].BackColor = Color.White;
                    }
                    else
                        listView1.Items[i].BackColor = Color.WhiteSmoke;
                }
            
            label4.Text = "COVID Cases";
            label5.Text = "COVID Deaths";
            if (casesbtn.Checked)
            {
                weeklybtn.Enabled = true;
                monthlybtn.Enabled = true;
                comboBox1.Items.Clear();
            }
            showGraph();
        }

        private void recoveriesbtn_Click(object sender, EventArgs e)
        {
            StreamReader recovs = new StreamReader("dailyvaccines.txt");
            
                listView1.SendToBack();
                listView2.BringToFront();
                while (recovs.Peek() != -1)
                {
                    string full = recovs.ReadLine();
                    string[] half = full.Split(',');
                    string[,] data = { { half[0], half[1], half[2] } };
                    int firstcolumn = data.GetLength(0);
                    for (int i = 0; i < firstcolumn; i++)
                    {
                        ListViewItem lists = new ListViewItem(data[i, 0]);
                        listView2.Items.Add(lists);
                        lists.SubItems.Add(data[i, 1]);
                        lists.SubItems.Add(data[i, 2]);
                    }
                }
                int numberofrows = listView2.Items.Count;
                for (int i = 0; i < numberofrows; i++)
                {
                    if (listView2.Items[i].Index % 2 == 0)
                    {
                        listView2.Items[i].BackColor = Color.White;
                    }
                    else
                        listView2.Items[i].BackColor = Color.WhiteSmoke;
                }
            
            label4.Text = "First Vaccine";
            label5.Text = "Fully Vaccinated";
            if (recoveriesbtn.Checked)
            {
                weeklybtn.Enabled = true;
                monthlybtn.Enabled = true;
                comboBox1.Items.Clear();
            }
            showGraph();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("Shinkansen", "Sh1nk@ns3nBull3ttra%n");
            client.UploadFile("ftp://66.220.9.50/My Documents/weekly.Txt", "weekly.txt");
            client.UploadFile("ftp://66.220.9.50/My Documents/weeklyvaccinates.Txt", "weeklyvaccinates.txt");
            this.timer1.Start();
            Account_Verification verify = new Account_Verification();
            verify.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader casesweeklyreport = new StreamReader("weekly.txt");
            StreamReader monthlyreport = new StreamReader("monthly.txt");
           

            if (casesbtn.Checked)
            {            
                if (isweeklypressed == true)
                {
                    while (casesweeklyreport.Peek() != -1)
                    {
                        string full = casesweeklyreport.ReadLine();
                        string[] half = full.Split(',');


                        label1.Text = comboBox1.SelectedItem.ToString();

                        bool ifvalue = label1.Text.Contains(half[0]);

                        if (ifvalue == true)
                        {
                            label2.Text = half[1].ToString();
                            label3.Text = half[2].ToString();
                        }

                    }
                }
                else if (ismonthlypressed == true)
                {
                    
                    while (monthlyreport.Peek() != -1)
                    {
                        string full = monthlyreport.ReadLine();
                        string[] half = full.Split(',');


                        label1.Text = comboBox1.SelectedItem.ToString();

                        bool ifvalue = label1.Text.Contains(half[0]);

                        if (ifvalue == true)
                        {
                            label2.Text = half[1].ToString();
                            label3.Text = half[2].ToString();
                        }

                    }

                }

            }
           else if (recoveriesbtn.Checked)
            {

                StreamReader recoveryweeklyreport = new StreamReader("weeklyvaccinates.txt");
                StreamReader recoverymonthlyreport = new StreamReader("monthlyvaccinates.txt");
                if (isweeklypressed == true)
                {
                    while (recoveryweeklyreport.Peek() != -1)
                    {
                        string full = recoveryweeklyreport.ReadLine();
                        string[] half = full.Split(',');
                        label1.Text = comboBox1.SelectedItem.ToString();
                        bool ifvalue = label1.Text.Contains(half[0]);
                        if (ifvalue == true)
                        {
                            label2.Text = half[1].ToString();
                            label3.Text = half[2].ToString();
                        }
                    }
                }
               else if(ismonthlypressed == true)
                {
                    while (recoverymonthlyreport.Peek() != -1)
                    {
                        string full = recoverymonthlyreport.ReadLine();
                        string[] half = full.Split(',');


                        label1.Text = comboBox1.SelectedItem.ToString();

                        bool ifvalue = label1.Text.Contains(half[0]);

                        if (ifvalue == true)
                        {
                            label2.Text = half[1].ToString();
                            label3.Text = half[2].ToString();
                        }

                    }
                }
            }
           
        }

       
    }
}