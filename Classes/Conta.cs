using System;

namespace DIO_Bank_DotNET
{
    public class Conta
    {
        public Conta(string nome, TipoConta tipoConta, double saldo, double credito)
        {
            this.Nome = nome;
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;

        }

        private string Nome { get; set; }
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public bool Sacar(double valorSaque) {

            if (this.Saldo - valorSaque < this.Saldo + this.Credito) {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;
            
            Console.WriteLine($"Saldo atual na conta de {this.Nome} é de R${this.Saldo}");//string interpolation

            return true;
        }

        public void Depositar(double valorDeposito) {

            this.Saldo += valorDeposito;
            Console.WriteLine($"Saldo atual na conta de {this.Nome} é de R${this.Saldo}");

        }

        public void Transferir(double valorTransferencia, Conta contaDestino) {
            //reuso de metodos 
            if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }

        }

    }
}