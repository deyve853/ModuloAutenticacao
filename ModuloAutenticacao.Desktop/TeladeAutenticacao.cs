
using ModuloAutenticacao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAutenticacao.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //objeto é uma instâcia da classe
            /*
             * 1- Coloque o nome da calsse 
             * 2- Defina o objeto
             * 3- Sinal de "="
             * 4- Operador New 
             * 5- Chamada ao construtor ( )
             */
            Usuario user = new Usuario();
            user.Login = txtLogin.Text;
            user.Senha = txtSenha.Text;

            if (user.Login.Equals(""))
            {
                MessageBox.Show("Login Obrigatorio");
                txtLogin.Focus();
            }
            else if (user.Senha.Equals(""))
            {
                MessageBox.Show("Usuario ou senha invalido");
                txtSenha.Focus();
            }
            else
            {
                MessageBox.Show("Sucesso!");
            }
        }
    }
}
