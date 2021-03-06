using QRCoder;
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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public DateTime dt1;
        int panel = -1;
        
        public Form1()
        {
            InitializeComponent();
            instance = this;
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

        public void btnSave_Click(object sender, EventArgs e)
        {
            int answer = 0;

            StreamWriter information = File.AppendText(@"C:\Users\Joyce Calangian\Documents\MJ\PUP\SUBJECTS\OBJECT ORIENTED PROGRAMMING\Contact Tracing File\Health_Information.txt");
            information.WriteLine("Date:" + datepickerMain.Value.ToString("MM/dd/yyyy"));
            information.WriteLine("Name:" + txtbxName1.Text);
            information.WriteLine("Address:" + txtbxAddress.Text);
            information.WriteLine("Age:" + txtbxAge.Text);
            information.WriteLine("Contact Number:" + txtbxContact.Text);
            information.WriteLine("Email:" + txtbxEmail.Text);
            information.WriteLine("Body Temp:" + txtbxBodyTemp.Text);

            //Sex
            if (rdbtnMale.Checked)
                information.WriteLine("Sex:Male");
            else
                information.WriteLine("Sex:Female");

            //Question 1
            if (rdbtnQ1Yes.Checked)
                information.WriteLine("Close contact w/ COVID within two weeks:Yes");
            else
                information.WriteLine("Close contact w/ COVID within two weeks:No");

            //Vaccination status
            if (rdbtnVaccinationYes.Checked)
                information.WriteLine("Vaccination Status:Fully Vaccinated");
            else if (rdbtnVaccinationFirstdose.Checked)
                information.WriteLine("Vaccination Status:First dose only");

            else if (rdbtnVaccinationNo.Checked)
                information.WriteLine("Vaccination Status:Not yet vaccinated");


            //Symptoms
            information.Write("Symptoms:");
            if (chckbxSymptoms1.Checked)
                information.Write("Fever" + ";");

            if (chckbxSymptoms2.Checked)
                information.Write("Breathing difficulties" + ";");

            if (chckbxSymptoms3.Checked)
                information.Write("Loss of taste or smell" + ";");

            if (chckbxSymptoms4.Checked)
                information.Write("Body aches" + ";");

            if (chckbxSymptoms5.Checked)
                information.Write("Dry cough" + ";");

            if (chckbxSymptoms6.Checked)
                information.Write("Sore throat" + ";");

            if (chckbxSymptoms7.Checked)
                information.Write("Runny nose" + ";");

            if (chckbxSymptoms8.Checked)
                information.Write("Diarrhea" + ";");

            if (chckbxSymptoms9.Checked)
                information.Write("Headache" + ";");





            information.WriteLine("");
            information.WriteLine("");
            information.Close();
            answer++;

            Application.Restart();
        }

        private void grpbxGender_Enter(object sender, EventArgs e)
        {


        }

        private void rdbtnQ1Yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void rdbtnVaccinationYes_CheckedChanged(object sender, EventArgs e)
        {


        }



        private void btnSeeResponse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2(this);
            form.Show();

        }

        private void bntQRCode_Click(object sender, EventArgs e)
        {
            
            panel *= 0;
            Form1 form1 = new Form1();

            if (panel == 1)
            {
                pnlQR.Hide();
               form1.Hide();
            }
            else
            {
                pnlQR.Show(); 
            }

            Generate();
            

        }

        private void Generate()
        {
            try
            {
                QRCodeGenerator qr = new QRCodeGenerator();

                
                var qrText = "Date: " + datepickerMain.Value.ToString("MM/dd/yyyy") + ";" +
                "Name: " + txtbxName1.Text + ";" +
                "Address: " + txtbxAddress.Text + ";" +
                "Age: " + txtbxAge.Text + ";" +
                "Contact Number: " + txtbxContact.Text + ";" +
                "Email: " + txtbxEmail.Text + ";" +
                "Body Temperature: " + txtbxBodyTemp.Text + ";" +
                "Gender: " + grpbxGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text + ";" +
                "Close contact w/ COVID within two weeks:: " + grpbxQ1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text + ";" +
                "Vaccination Status: " + grpbxQ4.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text + ";" +
                "Syptoms: " + ";" + " ●  " + grpbxQ2.Controls.OfType<CheckBox>().First(c => c.Checked).Text + ";";

                QRCodeData data = qr.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                pctrbxQR.Image = code.GetGraphic(5);

                
            }
            catch { }
            
           
        }
            
        
        private void btnDoneQr_Click(object sender, EventArgs e)
        {
            pnlQR.Hide();
        }

        private void pctrbxScan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3(this);
            form3.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
