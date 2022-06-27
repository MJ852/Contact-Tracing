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
        

        public Form2()
        {

            InitializeComponent();
            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnSeeAll_Click(object sender, EventArgs e)
        {
            AllData();
        }

        public void AllData()
        {
            lstvwSort.Items.Clear();
            StreamReader ReadInformation;
            ReadInformation = File.OpenText(@"C:\Users\Joyce\Documents\MJ\SUBJECTS\Health_Information.txt");

            while (!ReadInformation.EndOfStream)
            {
                lstbxSeeAll.Items.Add(ReadInformation.ReadLine());
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

        private void lstvwSort_SelectedIndexChanged(object sender, EventArgs e)
        {
           
    }

    private void lblData_Click(object sender, EventArgs e)
    {

    }


        public void datepicker_ValueChanged(object sender, EventArgs e)
        {
            lstbxSeeAll.Items.Clear();
            lstvwSort.Items.Clear();
            FilterDate();
           
           
            

        }

         private void btnClear_Click(object sender, EventArgs e)
        {
            lstvwSort.Items.Clear();
            lstbxSeeAll.Items.Clear();
        }

        private void FilterDate()
        {
            int counter = 0;
            string line;

            try
            {
                StreamReader ReadInformation;
                ReadInformation = File.OpenText(@"C:\Users\Joyce\Documents\MJ\SUBJECTS\Health_Information.txt");
                List<int> list = new List<int>();

                while ((line = ReadInformation.ReadLine()) != null)
                {
                    lstvwSort.Items.Add(line);
                    list.Add(int.Parse(line));
                    counter++;
                }

                int[] arr = list.ToArray();
                ReadInformation.Close();
            }
            catch { }
            
        }

       

    }
 }

