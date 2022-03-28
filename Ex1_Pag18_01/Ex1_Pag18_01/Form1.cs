using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag18_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                            MessageBox.Show("O mês é janeiro.");
                            break;
                        case 2:
                            MessageBox.Show("O mês é fevereiro.");
                            break;
                        case 3:
                            MessageBox.Show("O mês é março.");
                            break;
                        case 4:
                            MessageBox.Show("O mês é abril.");
                            break;
                        case 5:
                            MessageBox.Show("O mês é maio.");
                            break;
                        case 6:
                            MessageBox.Show("O mês é junho.");
                            break;
                        case 7:
                            MessageBox.Show("O mês é julho.");
                            break;
                        case 8:
                            MessageBox.Show("O mês é agosto.");
                            break;
                        case 9:
                            MessageBox.Show("O mês é setembro.");
                            break;
                        case 10:
                            MessageBox.Show("O mês é outubro.");
                            break;
                        case 11:
                            MessageBox.Show("O mês é novembro.");
                            break;
                        case 12:
                            MessageBox.Show("O mês é dezembro.");
                            break;
                    }
                }
            }
        }
    }
}
