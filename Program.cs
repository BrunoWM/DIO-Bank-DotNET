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
                        InserirNovaConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
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

        private static void Depositar()
        {
            Console.WriteLine("Depositar. \n\r");

            Console.WriteLine("Digite o id da conta: ");
            int idContaDeposito = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaContas[idContaDeposito].Depositar(valorDeposito: valorDeposito);
        }
        private static void Sacar()
        {
            Console.WriteLine("Sacar. \n\r");

            Console.WriteLine("Digite o id da conta: ");
            int idContaSaque = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaContas[idContaSaque].Sacar(valorSaque: valorSaque);
        }
        private static void Transferir()
        {
            Console.WriteLine("Transferir. \n\r");

            Console.WriteLine("Digite o id da conta origem: ");
            int idOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o id da conta destino: ");
            int idDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido: ");
            double valorTransf = double.Parse(Console.ReadLine());

            listaContas[idOrigem].Transferir(valorTransferencia: valorTransf,
                                            contaDestino: listaContas[idDestino]);
        }

        private static void InserirNovaConta()
        {
            Console.WriteLine("Criar nova conta:\n\r");

            Console.WriteLine("Nome do proprietário: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite '1' para pessoa física e '2' para pessoa juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o saldo: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(nome: entradaNome,
                                        tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito);

            listaContas.Add(novaConta);           
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
                Console.WriteLine("\n\r-------------------------------");
                Console.WriteLine($"id da conta: {i}.");
                i++;
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
