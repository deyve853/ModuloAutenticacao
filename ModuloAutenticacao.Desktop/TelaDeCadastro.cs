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
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        private void TelaDeCadastro_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
         

        private void textBox1_TextChanged(object sender, EventArgs e)
        

        {
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            txtLogin.Text = "o Leave foi acionado";
            txtLogin.BackColor = Color.Red;
            txtLogin.Text = txtID.Text;
            txtLogin.BackColor = Color.White;
            //Clever
            string[] nome = txtID.Text.Split(' ');
            //txtLogin.Text = nome[0];
            //Yedo
            string substring = "";
            string[] subs = textBox2.Text.Split();
            foreach (string sub in subs)
            {
                //  MessageBox.Show($"Substring: {sub}");
                substring = sub;
            }
            //===================
            txtLogin.Text = $"{nome[0].ToLower()}.{substring.ToLower()}";

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaNivel tcu = new TelaNivel();
            tcu.Show();
        }
    }
}
