using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag11_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtValor.Text) || string.IsNullOrEmpty(txtDias.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                double price = Convert.ToDouble(txtValor.Text);
                int days = Convert.ToInt32(txtDias.Text);

                double calc = ((price * 0.05) * days) + price;
                MessageBox.Show("O valor a ser pago é de: " + calc);
            }
        }
    }
}
