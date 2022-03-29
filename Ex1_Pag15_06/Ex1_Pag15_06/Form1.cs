using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtParcelas.Text) || string.IsNullOrEmpty(txtSalario.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                double valor = Convert.ToDouble(txtValor.Text);
                double salario = Convert.ToDouble(txtSalario.Text);
                int parcelas = Convert.ToInt32(txtParcelas.Text);

                double valorParcelas = valor / parcelas;

                if (valorParcelas <= (30 * (salario / 100)))
                {
                    MessageBox.Show("Empréstimo Aprovado.");
                }
                else
                {
                    MessageBox.Show("Empréstimo Negado.");
                }
            }
        }
    }
}
