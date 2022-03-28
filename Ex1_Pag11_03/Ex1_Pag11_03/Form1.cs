using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag11_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int anos = Convert.ToInt32(txtAnos.Text);
            int meses = Convert.ToInt32(txtMeses.Text);
            int dias = Convert.ToInt32(txtDias.Text);

            int calc = (anos * 365) + (meses * 30) + dias;
            MessageBox.Show("A idade da pessoa em dias é de: " + calc);
        }
    }
}
