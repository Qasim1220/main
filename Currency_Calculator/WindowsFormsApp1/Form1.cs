using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Exit Form1.

            DialogResult iExit;

            // Create Message box confirm exit.

            iExit = MessageBox.Show("Confirm you want to leave", "Currency Converter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clearing input on textboxes.

            Valuetxt.Clear();
            Value2txt.Clear();

            // Unchecking choices on RadioButtons for Value.

            EuroBtn.Checked = false;
            PoundBtn.Checked = false;
            DollarBtn.Checked = false;

            // Unchecking choices on RadioButtons for Value2.

            EuroBtn2.Checked = false;
            PoundBtn2.Checked = false;
            DollarBtn2.Checked = false;
        }

        private void Valuetxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void ConBtn_Click(object sender, EventArgs e)
        {

            // Original Value.

            double Value = float.Parse(Valuetxt.Text);

            // Creating Converted Value.

            double value2 = 0;

           
            // Euro Conversion //

            if (EuroBtn.Checked && EuroBtn2.Checked)
            {
                value2 = Value / Rates.myEuro[0];
                Exchangelbl.Text = Convert.ToString(Rates.myEuro[0]);
            }
            else if (EuroBtn.Checked && PoundBtn2.Checked)
            {
                value2 = Value / Rates.myEuro[1];
                Exchangelbl.Text = Convert.ToString(Rates.myEuro[1]);
            }
            else if (EuroBtn.Checked && DollarBtn2.Checked)
            {
                value2 = Value * Rates.myEuro[2];
                Exchangelbl.Text = Convert.ToString(Rates.myEuro[2]);
            }

            // Pound Sterling Conversion //

            if (PoundBtn.Checked && EuroBtn2.Checked)
            {
                value2 = Value * Rates.myPound[1];
                Exchangelbl.Text = Convert.ToString(Rates.myPound[1]);
            }
            else if (PoundBtn.Checked && PoundBtn2.Checked)
            {
                value2 = Value / Rates.myPound[0];
                Exchangelbl.Text = Convert.ToString(Rates.myPound[0]);
            }
            else if (PoundBtn.Checked && DollarBtn2.Checked)
            {
                value2 = Value * Rates.myPound[2];
                Exchangelbl.Text = Convert.ToString(Rates.myPound[2]);
            }

            // Dollar Conversion //

            if (DollarBtn.Checked && EuroBtn2.Checked)
            {
                value2 = Value * Rates.myDollar[1];
                Exchangelbl.Text = Convert.ToString(Rates.myDollar[1]);
            }
            else if (DollarBtn.Checked && PoundBtn2.Checked)
            {
                value2 = Value * Rates.myDollar[2];
                Exchangelbl.Text = Convert.ToString(Rates.myDollar[2]);
            }
            else if (EuroBtn.Checked && DollarBtn2.Checked)
            {
                value2 = Value / Rates.myDollar[0];
                Exchangelbl.Text = Convert.ToString(Rates.myDollar[0]);
            }

            // Display Result.

            Math.Round(value2);

            Value2txt.Text = Convert.ToString(value2+ "$");  
        }

        private void AlterBtn_Click(object sender, EventArgs e)
        {
            // Open new form 2 by Alter Button.

            Form2 F2 = new Form2();
            F2.Show();   
        }

        private void Value2txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Value2txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Exchangelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
