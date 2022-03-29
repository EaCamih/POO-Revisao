using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum1.Text) || string.IsNullOrEmpty(txtNum2.Text) || string.IsNullOrEmpty(txtNum3.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                int n1 = Convert.ToInt32(txtNum1.Text);
                int n2 = Convert.ToInt32(txtNum2.Text);
                int n3 = Convert.ToInt32(txtNum3.Text);
                int aux = 0;

                if (n1 > n2)
                {
                    aux = n1;
                    n1 = n2;
                    n2 = aux;
                }
                if (n1 > n3)
                {
                    aux = n1;
                    n1 = n3;
                    n3 = aux;
                }
                if (n2 > n3)
                {
                    aux = n2;
                    n2 = n3;
                    n3 = aux;
                }

                MessageBox.Show("Os números em ordem crescente são: " + n1 + ", " + n2 + " e " + n3);
            }
        }
    }
}
