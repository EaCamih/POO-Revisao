using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMov.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtNumber.Text) || string.IsNullOrEmpty(txtSaldo.Text) || string.IsNullOrEmpty(txtQuant.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else if(txtMov.Text != "depósito" && txtMov.Text != "retirada")
            {
                MessageBox.Show("A movimentação deve ser depósito ou retirada");
            }
            else
            {
                double saldo = Convert.ToDouble(txtSaldo.Text);
                string nome = Convert.ToString(txtName.Text);
                int numero = Convert.ToInt32(txtNumber.Text);
                string tipo = Convert.ToString(txtMov.Text);
                double quantidade = Convert.ToDouble(txtQuant.Text);

                if (tipo == "depósito")
                {
                    double calc = saldo + quantidade;
                    MessageBox.Show("Saldo atual da conta: " + calc);
                }
                else if(tipo == "retirada")
                {
                    double calc = saldo - quantidade;
                    MessageBox.Show("Saldo atual da conta: " + calc);
                }
            }
        }
    }
}
