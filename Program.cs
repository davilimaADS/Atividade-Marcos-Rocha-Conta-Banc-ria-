using System;
namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEspecial contaEspecial = new ContaEspecial();  
            contaEspecial.NumeroDaConta = 1234;
            contaEspecial.Titular = "Davi";
            contaEspecial.Depositar(800);
            contaEspecial.Sacar(500);
            contaEspecial.VerSaldo();  
        }
    }
}