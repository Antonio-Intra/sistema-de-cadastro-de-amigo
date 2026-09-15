using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.model
{
    public class Amigo
    {
        public string Apelido { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Amigo(string apelido, string telefone, string email)
        {
            Apelido = apelido;
            Telefone = telefone;
            Email = email;
        }

        // Formatação do texto exibido no ListBox da interface
        public override string ToString()
        {
            return $"{Apelido} - Tel: {Telefone} | E-mail: {Email}";
        }
    }
}