using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiarias.Text))
            {
                MessageBox.Show("TextBox Vazia.");
            }
            else
            {
                int diarias = Convert.ToInt32(txtDiarias.Text);
                double val1 = diarias * 180;
                double taxa = 0;

                if(diarias > 15)
                {
                    taxa = diarias * 10;
                }
                if(diarias == 15)
                {
                    taxa = diarias * 12;
                }
                if(diarias < 15)
                {
                    taxa = diarias * 15;
                }

                double valorPagar = val1 + taxa;
                MessageBox.Show("Valor a ser pago: " + valorPagar);
            }
        }
    }
}
