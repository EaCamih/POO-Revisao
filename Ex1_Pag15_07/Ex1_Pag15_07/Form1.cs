using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor1.Text) || string.IsNullOrEmpty(txtValor2.Text) || string.IsNullOrEmpty(txtValor3.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                int n1 = Convert.ToInt32(txtValor1.Text);
                int n2 = Convert.ToInt32(txtValor2.Text);
                int n3 = Convert.ToInt32(txtValor3.Text);
                int aux = 0;

                if(n1 > aux)
                {
                    aux = n1;
                }
                if(n2 > aux)
                {
                    aux = n2;
                }
                if(n3 > aux)
                {
                    aux = n3;
                }

                MessageBox.Show("O maior numero é: " + aux);
            }
        }
    }
}
