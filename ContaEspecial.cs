using System;
namespace Conta{
    public class ContaEspecial : ContaCorrente {
 private double limite = 900;

 public double Limite { get => limite; set => limite = value; }

 public void ConsultaLimite()
 {
     Console.WriteLine("O Limite Atual é {0}", Limite);
 }

 public double DiminuiLimite(double _valor)
 {
      double novolimite = limite - _valor;
     
    return novolimite;

 }

 public double AumentaLimite(double _valor)
 {
     double novolimite = limite + _valor;

     return novolimite;

 }
    }
}