using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag11_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtQuantity.text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double dollarPrice = 4.79;

                double calc = (price * quantity) * dollarPrice;
                MessageBox.Show("O preço a ser pago em Reais é de: " + calc);
            }
        }
    }
}
