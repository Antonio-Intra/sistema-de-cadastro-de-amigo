using System;
using System.Windows.Forms;
using WpfApp1.control;
using WpfApp1.model;

namespace WpfApp1.view
{
    public partial class FormRedeAmigos : Form
    {
        private readonly AmigoController _controller;

        public FormRedeAmigos()
        {
            InitializeComponent();
            _controller = new AmigoController();
        }

        // Ação do botão Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string apelido = txtApelido.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;

            if (_controller.CadastrarAmigo(apelido, telefone, email))
            {
                MessageBox.Show("Amigo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                AtualizarListBox(_controller.ListarTodos());
            }
            else
            {
                MessageBox.Show("Preencha pelo menos o Apelido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Ação do botão Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string apelido = txtApelido.Text;
            Amigo amigo = _controller.BuscarAmigo(apelido);

            if (amigo != null)
            {
                txtTelefone.Text = amigo.Telefone;
                txtEmail.Text = amigo.Email;

                listBoxAmigos.Items.Clear();
                listBoxAmigos.Items.Add(amigo);
            }
            else
            {
                MessageBox.Show("Amigo não encontrado pelo Apelido informado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Ação do botão Remover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            string apelido = txtApelido.Text;

            if (_controller.RemoverAmigo(apelido))
            {
                MessageBox.Show("Amigo removido com sucesso!", "Remoção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                AtualizarListBox(_controller.ListarTodos());
            }
            else
            {
                MessageBox.Show("Não foi possível remover. Verifique o Apelido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ação do botão Listar Todos
        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            AtualizarListBox(_controller.ListarTodos());
        }

        // Métodos de apoio
        private void AtualizarListBox(System.Collections.Generic.List<Amigo> lista)
        {
            listBoxAmigos.Items.Clear();
            foreach (var amigo in lista)
            {
                listBoxAmigos.Items.Add(amigo);
            }
        }

        private void LimparCampos()
        {
            txtApelido.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtApelido.Focus();
        }
    }
}