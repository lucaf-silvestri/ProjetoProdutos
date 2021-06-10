using System;
using System.Collections.Generic;
using ProjetoProdutos.Interfaces;

namespace ProjetoProdutos.Classes
{
    public class Login : Marca, ILogin
    {
        public bool logado = false;

        public Login()
        {
            bool acabouMar = false;
            bool acabouLog = false;
            bool acabouTudo = false;
            int c = 1;
            Marca marca = new Marca();
            List<Marca> ListaMarca = marca.ListarMarca();
            Usuario usuario = new Usuario();
            List<Usuario> ListaUsers = usuario.ListarUser();

            do
            {
                do
                {
                    Console.WriteLine(@"
==============================
|    Selecione uma opção:    |
|----------------------------|
|  1- Fazer Login            |
|  2- Cadastrar Usuário      |
|  3- Deletar Usuário        |
|  4- Informações do Usuário |
|  5- Sair                   |
==============================");
                    string opcaoLog = Console.ReadLine();

                    switch (opcaoLog)
                    {
                        case "1":
                            do
                            {
                                Console.WriteLine(@"
==============================
|    Selecione uma opção:    |
|----------------------------|
|    1- Cadastrar Marca      |
|     2- Listar Marcas       |
|     3- Remover Marca       |
|         4- Sair            |
==============================");
                                string opcao = Console.ReadLine();

                                switch (opcao)
                                {
                                    case "1":
                                        Marca marc = new Marca();

                                        Console.WriteLine("Digite o nome da marca a ser cadastrada:");
                                        marc.NomeMarca = Console.ReadLine();
                                        marc.codigo = c;
                                        c++;
                                        marc.DataCadastro = DateTime.Now;
                                        marca.CadastrarMarca(marc);
                                        acabouMar = false;

                                        break;

                                    case "2":
                                        if (ListaMarca.Count <= 0)
                                        {
                                            Console.WriteLine("Lista Vazia!");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Marcas Cadastradas:");

                                            foreach (var i in ListaMarca)
                                            {
                                                Console.WriteLine($@"
=============================
    Marca:{i.NomeMarca}     
    Código: {i.codigo}      
    Data: {i.DataCadastro}
=============================
    ");
                                                acabouMar = false;
                                            }
                                        }

                                        break;


                                    case "3":

                                        if (ListaMarca.Count <= 0)
                                        {
                                            Console.WriteLine("Lista vazia!");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Qual o nome da marca que deseja remover?");
                                            foreach (var i in ListaMarca)
                                            {
                                                Console.WriteLine($"Marca:{i.NomeMarca}");
                                            }

                                            marca.marcaRemover = Console.ReadLine();
                                            marca.DeletarMarca();
                                            Console.WriteLine($"Qualquer marca com o nome {marca.marcaRemover} foi removida.");



                                            acabouMar = false;
                                        }
                                        break;

                                    case "4":
                                        acabouMar = true;
                                        acabouLog = false;
                                        break;

                                    default:
                                        {
                                            acabouMar = false;
                                        }
                                        break;
                                }
                            } while (acabouMar == false);
                            break;

                        case "2":
                            Logar();


                            acabouLog = false;
                            break;

                        case "3":

                            if (ListaUsers.Count <= 0)
                            {
                                Console.WriteLine("Sem usários cadastrados");

                            }
                            else
                            {
                                Usuario user = new Usuario();
                                Console.WriteLine("Qual o nome do usuário que deseja remover?");
                                foreach (var i in ListaUsers)
                                {
                                    Console.WriteLine($"Usuário :{i.nomeUser}");
                                }

                                user.userRemover = Console.ReadLine();
                                user.DeletarUser();
                                Console.WriteLine($"Qualquer usuário com o nome {user.userRemover} foi removido.");
                            }
                            break;

                        case "4":
                            acabouLog = false;
                            break;

                        case "5":
                            acabouLog = true;
                            acabouTudo = true;
                            break;

                        default:
                            {
                                acabouLog = false;
                            }
                            break;
                    }
                } while (acabouLog == false);
            } while (acabouTudo == false);
        }



        public string Logar()
        {

            do
            {
                if (true)
                {

                }
                else
                {

                }

            } while (logado == false);
            logado = true;
            return "logado";
        }
        public string Deslogar()
        {
            logado = false;
            return "logado";
        }


    }
}