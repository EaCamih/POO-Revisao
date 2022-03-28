using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_02
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtPreco.Text) || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                double preco = Convert.ToDouble(txtPreco.Text);
                int quantity = Convert.ToInt32(txtQuantidade);

                if(quantity > 10)
                {

                    double calc = preco - (preco * 5 / 100);
                    MessageBox.Show("O preço a ser pago é de: " + calc);

                }
                else if (quantity > 5)
                {

                    double calc = preco - (preco * 3 / 100);
                    MessageBox.Show("O preço a ser pago é de: " + calc);

                }
                else
                {

                    double calc = preco - (preco * 2 / 100);
                    MessageBox.Show("O preço a ser pago é de: " + calc);

                }
            }
        }
    }
}
