using System;

namespace ProjetoProdutos.Classes
{
    public abstract class Usuario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int dataCadastro { get; set; }

        public string cadastrarUsuario()
        {
            return nome;
        }
        public string deletarUsuario()
        {
            return nome;
        }
    }
}