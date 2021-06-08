using System;

namespace ProjetoProdutos.Classes
{
    public abstract class Produto
    {
        public int codigo { get; set; }
        public string nomeProduto { get; set; }
        public float preco { get; set; }
        public string marca { get; set; }
        public string cadastradoPor { get; set; }

        //public ??? listaDeProdutos {get; set;}
        public string cadastrarProduto()
        {
            return nomeProduto;
        }

        //public void ListarProduto()

        public string deletarProduto()
        {
            return nomeProduto;
        }
    }
}