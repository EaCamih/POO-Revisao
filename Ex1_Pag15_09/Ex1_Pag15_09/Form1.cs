using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMatricula.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtNota1.Text) || string.IsNullOrEmpty(txtNota2.Text) || string.IsNullOrEmpty(txtNota3.Text))
            {
                MessageBox.Show("TextBox Vazio.");
            }
            else
            {
                int n1 = Convert.ToInt32(txtNota1.Text);
                int n2 = Convert.ToInt32(txtNota2.Text);
                int n3 = Convert.ToInt32(txtNota3.Text);
                int nFinal = n1 + n2 + n3;
                string conceito = "";

                if(nFinal >= 9 && nFinal <= 10)
                {
                    conceito = "A";
                }
                if(nFinal >= 7 && nFinal < 9)
                {
                    conceito = "B";
                }
                if(nFinal >= 5 && nFinal < 7)
                {
                    conceito = "C";
                }
                if (nFinal >= 3 && nFinal < 5)
                {
                    conceito = "D";
                }
                if (nFinal < 3)
                {
                    conceito = "R";
                }

                lblNome.Text = "Nome: " + txtNome.Text;
                lblMatricula.Text = "Matricula: " + txtMatricula.Text;
                lblClassificacao.Text = "Classificação:" + conceito;
            }
        }
    }
}
