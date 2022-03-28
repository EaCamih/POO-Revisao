using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag18_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                if(numero < 1 || numero > 12)
                {
                    MessageBox.Show("Número deve ser entre 1 e 12");
                }
                else
                {
                    switch (numero)
                    {
                        case 1:
                            MessageBox.Show("O mês de janeiro tem 31 dias.");
                            break;


                        case 2:
                            MessageBox.Show("O mês de fevereiro tem 28 ou 29 dias.");
                            break;

                        case 3:
                            MessageBox.Show("O mês de março tem 31 dias.");
                            break;

                        case 4:
                            MessageBox.Show("O mês de abril tem 30 dias.");
                            break;

                        case 5:
                            MessageBox.Show("O mês de maio tem 31 dias.");
                            break;

                        case 6:
                            MessageBox.Show("O mês de junho tem 30 dias.");
                            break;

                        case 7:
                            MessageBox.Show("O mês de julho tem 31 dias.");
                            break;

                        case 8:
                            MessageBox.Show("O mês de agosto tem 31 dias.");
                            break;

                        case 9:
                            MessageBox.Show("O mês de setembro tem 30 dias.");
                            break;

                        case 10:
                            MessageBox.Show("O mês de outubro tem 31 dias.");
                            break;

                        case 11:
                            MessageBox.Show("O mês de novembro tem 30 dias.");
                            break;

                        case 12:
                            MessageBox.Show("O mês de dezembro tem 31 dias.");
                            break;
                    }
                }
            }
        }
    }
}
