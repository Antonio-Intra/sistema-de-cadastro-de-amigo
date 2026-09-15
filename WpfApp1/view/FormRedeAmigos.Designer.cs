using System;
using System.Windows.Forms;
using System.Drawing;

namespace WpfApp1.view
{
    partial class FormRedeAmigos
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtApelido;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private ListBox listBoxAmigos;
        private Button btnCadastrar;
        private Button btnBuscar;
        private Button btnRemover;
        private Button btnListarTodos;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtApelido = new TextBox();
            this.txtTelefone = new TextBox();
            this.txtEmail = new TextBox();
            this.listBoxAmigos = new ListBox();
            this.btnCadastrar = new Button();
            this.btnBuscar = new Button();
            this.btnRemover = new Button();
            this.btnListarTodos = new Button();

            this.SuspendLayout();
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new Point(12, 12);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new Size(200, 23);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new Point(12, 41);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new Size(200, 23);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(12, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(200, 23);
            // 
            // listBoxAmigos
            // 
            this.listBoxAmigos.Location = new Point(12, 100);
            this.listBoxAmigos.Name = "listBoxAmigos";
            this.listBoxAmigos.Size = new Size(360, 150);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new Point(230, 10);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new Size(140, 25);
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new Point(230, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new Size(140, 25);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new Point(230, 70);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new Size(140, 25);
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new EventHandler(this.btnRemover_Click);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new Point(230, 100);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new Size(140, 25);
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new EventHandler(this.btnListarTodos_Click);

            // 
            // FormRedeAmigos
            // 
            this.ClientSize = new Size(384, 261);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.listBoxAmigos);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnListarTodos);
            this.Name = "FormRedeAmigos";
            this.Text = "Rede de Amigos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
