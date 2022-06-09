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
    public partial class txtbxName : Form
    {
        public txtbxName()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void txtbxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbxName_Load(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter information = File.AppendText(@"C:\Users\Joyce Calangian\Documents\MJ\PUP\SUBJECTS\Health Information.txt");
            information.WriteLine("Date: " + txtbxDate.Text);
            information.WriteLine("Name: " + txtbxName1.Text);
            information.WriteLine("Address: " + txtbxAddress.Text);
            information.WriteLine("Age: " + txtbxAge.Text);
            information.WriteLine("Contact Number: " + txtbxContact.Text);
            information.WriteLine("Email: " + txtbxEmail.Text);
            information.WriteLine("Body Temp:  " + txtbxBodyTemp.Text);

            if (rdbtnMale.Checked)
            {
                information.WriteLine("Sex: Male");
            }
            else
            {
                information.WriteLine("Sex: Female");
            }

            if(rdbtnQ1Yes.Checked)
            {
                information.WriteLine("Close contact w/ COVID within two weeks: Yes");
            }
            else
            {
                information.WriteLine("Close contact w/ COVID within two weeks: No");
            }

            information.WriteLine("");
            information.Close();
        }

        private void grpbxGender_Enter(object sender, EventArgs e)
        {
           

        }

        private void rdbtnQ1Yes_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
