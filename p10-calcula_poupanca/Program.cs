using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - calcular Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            // 0.36% = 0.0036

            while (contadorMes <= 12)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses seu valor investido sera R$ " + valorInvestido);
                contadorMes++;
            }

            Console.ReadLine();
        }
    }
}
