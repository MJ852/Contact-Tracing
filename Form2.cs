using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form2 : Form
    {


        List<string> response = new List<string>();
        List<ListViewItem> items = new List<ListViewItem>();
        Form1 prevForm;
        

        public Form2(Form1 prevForm)
        {
            

            InitializeComponent();
            datepicker.CustomFormat = " ";
            datepicker.Format = DateTimePickerFormat.Custom;

            this.prevForm = prevForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnSeeAll_Click(object sender, EventArgs e)
        {
            AllData();
            datepicker.CustomFormat = " ";
            datepicker.Format = DateTimePickerFormat.Custom;
        }

        public void AllData(bool sorted = false)
        {
            lstbxSeeAll.Items.Clear();
            StreamReader ReadInformation;
            ReadInformation = File.OpenText(@"C:\Users\Joyce Calangian\Documents\MJ\PUP\SUBJECTS\Health_Information.txt");

            bool wait = false;
            while (!ReadInformation.EndOfStream)
            {
                String[] strLine = ReadInformation.ReadLine().Split(':');
                if (sorted && strLine[0] == "Date")
                    wait = strLine[1] != datepicker.Value.ToString("MM/dd/yyyy");
                
                if (wait && sorted)
                    continue;

                if (strLine[0] == "Symptoms")
                {
                    String[] strSymptoms = strLine[1].Split(';');

                    if (strLine[1] == "")
                        lstbxSeeAll.Items.Add("No Symptoms");
                    else
                        lstbxSeeAll.Items.Add(strLine[0] + ":");

                    foreach (String iSymptoms in strSymptoms)
                        if (iSymptoms != "")
                            lstbxSeeAll.Items.Add(" ●  " + iSymptoms);

                }
                else if (strLine[0] == "")
                    lstbxSeeAll.Items.Add("");
                else
                    lstbxSeeAll.Items.Add(strLine[0] + ":  " + strLine[1]);
                
            }

            ReadInformation.Close();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }


        
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.prevForm.Show();
        }


    }
 }

