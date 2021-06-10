using System;
using System.Collections.Generic;
using ProjetoProdutos.Intefaces;

namespace ProjetoProdutos.Classes
{
    public class Usuario : IUsuario
    {
        public int codigo { get; set; }
        public string nomeUser { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int dataCadastro { get; set; }
        public string userRemover { get; set; }

       
        List<Usuario> ListaUsers = new List<Usuario>();
        public string CadastrarUser(Usuario usuario)
        {
            ListaUsers.Add(usuario);
            return "Usuário Cadastrado";
        }
        public List<Usuario> ListarUser()
        {
            return ListaUsers;
        }
        public void DeletarUser()
        {
            ListaUsers.RemoveAll(x => x.nomeUser == userRemover);
        }

        public string CadastrarUser()
        {
            return "";
        }
    }
}