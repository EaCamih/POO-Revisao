using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtValor1.Text) || string.IsNullOrEmpty(txtValor2.Text) || string.IsNullOrEmpty(txtValor3.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                int v1 = Convert.ToInt32(txtValor1.Text);
                int v2 = Convert.ToInt32(txtValor2.Text);
                int v3 = Convert.ToInt32(txtValor3.Text);

                if(v1 == 90 || v2 == 90 || v3 == 90)
                {
                    MessageBox.Show("Triângulo Retângulo.");
                }
                if(v1 > 90 || v2 > 90 || v3 > 90)
                {
                    MessageBox.Show("Triângulo Obtusângulo.");
                }
                if(v1 < 90 && v2 < 90 && v3 < 90)
                {
                    MessageBox.Show("Triângulo Actutângulo.");
                }
            }
        }
    }
}
