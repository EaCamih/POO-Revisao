using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                string senha = Convert.ToString(txtSenha.Text);
                if(senha == "1234")
                {
                    MessageBox.Show("Acesso Permitido");
                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }
            }
        }
    }
}
