using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

class ListaTelefonica
{
    public static string[,] listaTel = new string[9999, 3];
    public static int ID = 0;
    static void Main()
    {

        static void listarListaTel() 
        {
            for (int i = 0; i < ID; i++) 
            {
                if (listaTel[i, 0] != null) 
                {
                    mostrarRegistro(i);
                }
            }
        }

        static void excluirRegistro(int i)
        {
            listaTel[i, 0] = " ";
            listaTel[i, 1] = " ";
            listaTel[i, 2] = " ";
        }

        static void excluirContatoNome()
        {
            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < listaTel.GetLength(0); i++)
            {
                if (listaTel[i, 1] == nome)
                {
                    excluirRegistro(i);
                    Console.WriteLine("Contato Excluído!");
                }
            }
            Console.WriteLine("-------------------------------------");
        }

        static void excluirContatoTelefone() 
        {
            Console.WriteLine("Digite um número de telefone:");
            uint telefone = uint.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < listaTel.GetLength(0); i++)
            {
                if (uint.TryParse(listaTel[i, 2], out uint numero) && numero == telefone)
                {
                    excluirRegistro(i);
                }
            }
            Console.WriteLine("-------------------------------------");
        }

        static void mostrarRegistro(int i)
        {
            Console.Write("ID: " + listaTel[i, 0]);
            Console.Write(" | Nome: " + listaTel[i, 1]);
            Console.WriteLine(" | Telefone: " + listaTel[i, 2]);
        }

        static void buscarContatoNome()
        {
            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < listaTel.GetLength(0); i++)
            {
                if (listaTel[i, 1] == nome)
                {
                    mostrarRegistro(i);
                }
            }
            Console.WriteLine("-------------------------------------");
        }

        static void buscarContatoTelefone()
        {
            Console.WriteLine("Digite um número de telefone:");
            uint telefone = uint.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < listaTel.GetLength(0); i++)
            {
                if (uint.TryParse(listaTel[i, 2], out uint numero) && numero == telefone)
                {
                    mostrarRegistro(i);
                }
            }
            Console.WriteLine("-------------------------------------");
        }

        static void adicionarContato(string nome, uint telefone)
        {
            listaTel[ID, 0] = ID.ToString();
            listaTel[ID, 1] = nome;
            listaTel[ID, 2] = telefone.ToString();
            ID++;
        }

        static void lerInformacoes()
        {
            uint telefone;
            string nome;

            Console.WriteLine("Insira um Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Insira um Telefone:");
            telefone = uint.Parse(Console.ReadLine());
            adicionarContato(nome, telefone);
            Console.WriteLine("-------------------------------------");
        }

        static void menu()
        {
            Console.WriteLine("Lista Telefônica");
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("2. Buscar Contato por Telefone");
            Console.WriteLine("3. Buscar Contato por nome");
            Console.WriteLine("4. Excluir Contato Completo por Telefone");
            Console.WriteLine("5. Excluir Contato Completo por Nome");
            Console.WriteLine("6. Ordenar Contatos por Telefone");
            Console.WriteLine("7. Ordenar Contatos por Nome");
            Console.WriteLine("8. Lista Todos os Contatos");

            int escolha = int.Parse(Console.ReadLine());

            escolheAcao(escolha);
        }

        static void escolheAcao(int escolha)
        {

            switch (escolha)
            {
                case 1:
                    lerInformacoes();
                    break;
                case 2:
                    buscarContatoTelefone();
                    break;
                case 3:
                    buscarContatoNome();
                    break;
                case 4:
                    excluirContatoTelefone();
                    break;
                case 5:
                    excluirContatoNome();
                    break;
                case 6:
                    //função ordenarContatoTelefone
                    break;
                case 7:
                    //função ordenarContatoNome
                    break;
                case 8:
                    listarListaTel();
                    break;
            }
        }

        while (true)
        {
            menu();
        }

    }
}