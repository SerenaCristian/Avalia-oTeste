using System;
using System.Runtime.ExceptionServices;
namespace AtividadesAvaliativaTestTechClass.Exercicios

{
    public class Fatorial
    {
        public double CalcularFatorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("O número não pode ser negativo");
            }

            long fatorial = 1;

            for (int i = numero; i > 1; i--)
            {
                fatorial *= i;
            }

            return fatorial;
        }
    }
}