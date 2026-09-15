using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;
using WpfApp1.model;
using WpfApp1.repository;

namespace WpfApp1.control
{
    public class AmigoController
    {
        private readonly AmigoRepository _repository;

        public AmigoController()
        {
            _repository = new AmigoRepository();
        }

        public bool CadastrarAmigo(string apelido, string telefone, string email)
        {
            if (string.IsNullOrWhiteSpace(apelido)) return false;

            var amigo = new Amigo(apelido, telefone, email);
            _repository.Adicionar(amigo);
            return true;
        }

        public Amigo BuscarAmigo(string apelido)
        {
            return _repository.ObterPorApelido(apelido);
        }

        public bool RemoverAmigo(string apelido)
        {
            return _repository.Remover(apelido);
        }

        public List<Amigo> ListarTodos()
        {
            return _repository.ObterTodos();
        }
    }
}