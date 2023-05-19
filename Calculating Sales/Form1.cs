using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculating_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalRetailValue = 0.0;
            int productNumber = Convert.ToInt32(productNumberTextBox.Text);
            int quantitySold = Convert.ToInt32(quantitySoldTextBox.Text);

            switch (productNumber)
            {
                case 1:
                    totalRetailValue += quantitySold * 2.98;
                    break;

                case 2:
                    totalRetailValue += quantitySold * 4.50;
                    break;

                case 3:
                    totalRetailValue += quantitySold * 9.98;
                    break;
            }

            totalRetailPriceTextBox.Text = totalRetailValue.ToString();
        }

        private void totalRetailPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
