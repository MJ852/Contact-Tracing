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
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cntxtDateSearch.Show(btnDateSearch, 0, btnDateSearch.Height);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnVaccination_Click(object sender, EventArgs e)
        {
            cntxtmnVaccination.Show(btnVaccination, 3, btnVaccination.Height);
        }

        public void btnSeeAll_Click(object sender, EventArgs e)
        {
            StreamReader ReadInformation;
            ReadInformation = File.OpenText(@"C:\Users\Joyce Calangian\Documents\MJ\PUP\SUBJECTS\Health_Information.txt");

            while (!ReadInformation.EndOfStream)
            {
                Response_List.Items.Add(ReadInformation.ReadLine());
            }

            ReadInformation.Close();
        }
    }
}
