using System;
using System.Collections.Generic;
using ProjetoProdutos.Classes;
using ProjetoProdutos.Interfaces;

namespace ProjetoProdutos 
{
    class Program : Login, ILogin
    {
        static void Main(string[] args)
        {
            Login log = new Login();
            
        }
    }
}
