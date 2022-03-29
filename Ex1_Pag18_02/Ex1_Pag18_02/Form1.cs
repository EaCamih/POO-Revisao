using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag18_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtType.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else if(txtType.Text != "importado" && txtType.Text != "nacional")
            {
                MessageBox.Show("O tipo deve ser importado ou nacional.");
            }
            else
            {
                string name = Convert.ToString(txtName.Text);
                double price = Convert.ToDouble(txtPrice.Text);
                string type = Convert.ToString(txtType.Text);

                if(type == "importado")
                {
                    double calc = price * 4.79;
                    label4.Text = "Nome do produto: " + name;
                    label5.Text = "Nacional ou Importado: " + type;
                    label6.Text = "Preço em R$: " + calc;
                }
                else if(type == "nacional")
                {
                    label4.Text = "Nome do produto: " + name;
                    label5.Text = "Nacional ou Importado: " + type;
                    label6.Text = "Preço em R$: " + price;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
