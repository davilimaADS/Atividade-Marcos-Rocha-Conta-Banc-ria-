using System;
namespace Conta
{
    public class ContaCorrente
    {
        public int NumeroDaConta;
        public string? Titular;

        public double Saldo { get; private set; }

        public void VerSaldo()
        {
            Console.WriteLine($"Saldo da conta: {Saldo}");
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }
        }
    }

}