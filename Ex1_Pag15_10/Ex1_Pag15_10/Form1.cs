using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Pag15_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cb1.Text == "" || cb2.Text == "" || cb3.Text == "" || cb4.Text == "" || cb5.Text == "")
            {
                MessageBox.Show("Por favor responda as questões.");
            }
            else
            {
                int part = 0;
                if(cb1.Text == "Sim")
                {
                    part++;
                }
                if (cb2.Text == "Sim")
                {
                    part++;
                }
                if (cb3.Text == "Sim")
                {
                    part++;
                }
                if (cb4.Text == "Sim")
                {
                    part++;
                }
                if (cb5.Text == "Sim")
                {
                    part++;
                }

                if(part == 2)
                {
                    MessageBox.Show("Suspeito.");
                }
                else if(part >= 3 && part <= 4)
                {
                    MessageBox.Show("Cúmplice");
                }
                else if(part == 5)
                {
                    MessageBox.Show("Assassino.");
                }
                else
                {
                    MessageBox.Show("Inocente");
                }
            }
        }
    }
}
