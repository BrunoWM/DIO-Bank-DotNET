using System;

namespace DIO_Bank_DotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conta bruno = new Conta("Bruno W.", TipoConta.PessoaFisica, 1000, 1000);
            //Console.WriteLine(bruno.ToString());
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
