using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloAutenticacao.Classes;
using ModuloAuteticacao.Classes;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaNivel : Form
    {
        public TelaNivel()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarResponsabilidades();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarResponsabilidades();
        }
        private void CarregarResponsabilidades()
        {
            NivelDAO nivelPesquisa = new NivelDAO();

            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            NivelDAO nivelDAO = new NivelDAO();
            MessageBox.Show(nivelDAO.Pesquisar("Jose"));
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {

        }
        public string Pesquisar(string nome)
        {
            return $"Olá {nome}";
        }
    }
}
