using System;

namespace DIO_Bank_DotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conta bruno = new Conta("Bruno W.", TipoConta.PessoaFisica, 1000, 1000);
            //Console.WriteLine(bruno.ToString());

            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario != "X")
            {
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
                        Dpositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
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
