using System;
using System.Collections.Generic;
using ProjetoProdutos.Interfaces;

namespace ProjetoProdutos.Classes
{
    public class Marca : IMarca
    {
        public int codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        public string marcaRemover { get; set; }
        List<Marca> ListaMarca = new List<Marca>();
        public void CadastrarMarca(Marca marca)
        {
            ListaMarca.Add(marca);
        }
        public List<Marca> ListarMarca()
        {
            return ListaMarca;
        }
        public void DeletarMarca()
        {
            ListaMarca.RemoveAll(x => x.NomeMarca == marcaRemover);
        }
    }
}