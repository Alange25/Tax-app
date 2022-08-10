using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            // Clear all the text fields.
            totalTextBox.Text = "";
            CustomTextBox.Text = "";
            GrandTotal.Text = "";
            totalTextBox.Focus();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            // The exit button. 
            this.Close();
        }

        private void five_percentbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaring three varibles one from user input.
                double five;
                double total;
                five = double.Parse(totalTextBox.Text);

                // Calculate the percentage.
                double five_percent = (five * 5) / 100;
                total = (five + five_percent);
                
                // Display the tax total.
                tax.Text = five_percent.ToString("C");

                // Display the grand total.
                GrandTotal.Text = total.ToString("C");
            }
            // In case of error display error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void ten_percentbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaring three varibles one from user input.
                double ten;
                double total;
                ten = double.Parse(totalTextBox.Text);

                // Calculate the percentage.
                double ten_percent = (ten * 10) / 100;
                total = (ten + ten_percent);

                // Display the tax total.
                tax.Text = ten_percent.ToString("C");

                // Display the grand total.
                GrandTotal.Text = total.ToString("C");
            }
            // In case of error display error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fifteen_percentbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaring three varibles one from user input.
                double fifteen;
                double total;
                fifteen = double.Parse(totalTextBox.Text);

                // Calculate the percentage.
                double fifteen_percent = (fifteen * 15) / 100;
                total = (fifteen + fifteen_percent);
                
                // Display the tax total.
                tax.Text = fifteen_percent.ToString("C");

                // Display the grand total.
                GrandTotal.Text = total.ToString("C");
            }
            // In case of error display error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void twenty_percentbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaring three varibles one from user input.
                double twenty;
                double total;
                twenty = double.Parse(totalTextBox.Text);

                // Calculate the percentage.
                double twenty_percent = (twenty * 20) / 100;
                total = (twenty + twenty_percent);

                // Display the tax total.
                tax.Text = twenty_percent.ToString("C");  

                // Display the grand total.
                GrandTotal.Text = total.ToString("C");
            }
            // In case of error display error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Custombtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaring three varibles one from user input.
                double custom;
                double percent;
                double total;
                custom = double.Parse(CustomTextBox.Text);
                percent = double.Parse(totalTextBox.Text);

                // Calculate the percentage.
                double percentage = (percent * custom) / 100;
                total = (percent + percentage);

                // Display the tax total.
                tax.Text = percentage.ToString("C");

                // Display the grand total.
                GrandTotal.Text = total.ToString("C");
            }
            // In case of error display error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
