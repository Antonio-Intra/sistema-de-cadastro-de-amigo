using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApp1.model;


namespace WpfApp1.repository
{
    public class AmigoRepository
    {
        // Camada BD simulada usando List
        private readonly List<Amigo> _tabelaAmigos = new List<Amigo>();

        public void Adicionar(Amigo amigo)
        {
            _tabelaAmigos.Add(amigo);
        }

        public List<Amigo> ObterTodos()
        {
            return _tabelaAmigos;
        }

        public Amigo ObterPorApelido(string apelido)
        {
            return _tabelaAmigos.FirstOrDefault(a => a.Apelido.Equals(apelido, StringComparison.OrdinalIgnoreCase));
        }

        public bool Remover(string apelido)
        {
            var amigo = ObterPorApelido(apelido);
            if (amigo != null)
            {
                _tabelaAmigos.Remove(amigo);
                return true;
            }
            return false;
        }
    }
}
