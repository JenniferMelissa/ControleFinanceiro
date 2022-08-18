using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.View
{
    public partial class Form1 : Form
    {
        string email = "", senha = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 
             * O que é uma variável?
             * Tipos de variáveis
             * Declarar ou omitir o tipo
            var email = "cecilia@minhavovo.com.br";
            int senha = 123456;
            */


            email = textBox1.Text;
            senha = textBox2.Text;

            MessageBox.Show($"Vó Cecilia seu email {email} esta correto?");


            MessageBox.Show("Olá C#!");

            if (email.Equals("ceci@gmail.com") && senha.Equals("123"))
            {
                MessageBox.Show("valido");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (senha.Equals("123"))
            {
                button1.Enabled = true;
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}


if (email.Equals("ceci@gmail.com") && senha.Equals("123"))
{

}
