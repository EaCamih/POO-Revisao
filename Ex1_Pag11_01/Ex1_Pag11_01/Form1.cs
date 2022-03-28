using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag11_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoras.Text) || string.IsNullOrEmpty(txtMinutos.Text) || string.IsNullOrEmpty(txtSegundos.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                int horas = Convert.ToInt32(txtHoras.Text);
                int minutos = Convert.ToInt32(txtMinutos.Text);
                int segundos = Convert.ToInt32(txtSegundos.Text);

                int calc = (horas * 3600) + (minutos * 60) + segundos;
                MessageBox.Show("O tempo gasto em segundos é de: " + calc);
            }
        }
    }
}
