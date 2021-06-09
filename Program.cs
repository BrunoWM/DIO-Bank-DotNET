using System;
using System.Collections.Generic;

namespace DIO_Bank_DotNET
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = "";

            do {

                opcaoUsuario = ObterOpcaoUsuario();
                
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        //InserirNovaConta();
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Dpositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }while(opcaoUsuario != "X");

            Console.WriteLine("Sitema encerrado.");
            Console.WriteLine("Agradecemos por escolher uma agência WILL!");
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas:");
            
            if (listaContas.Count == 0) {
                    Console.WriteLine("Nenhuma conta cadastrada.");
                    return;
            }

            int i = 0;
            foreach(Conta conta in listaContas) {
                Console.WriteLine("-------------------------------")
                Console.WriteLine($"id da conta: {i}. \n\r");
                Console.WriteLine(conta.ToString());
            }
        }

        private static string ObterOpcaoUsuario()
        {
            string menu = "";
            menu += "\n\r WILL Bancos ao seu dispor!";
            menu += "\n\r Informe a opção desejada:";
            menu += "\n\r 1 - Listar contas.";
            menu += "\n\r 2 - Inserir nova conta.";
            menu += "\n\r 3 - Transferir.";
            menu += "\n\r 4 - Sacar.";
            menu += "\n\r 5 - Depositar.";
            menu += "\n\r C - Limpar tela.";
            menu += "\n\r X - Sair. \n\r";
            Console.WriteLine(menu);
            
            string opcUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcUsuario;
        }
    }
}
