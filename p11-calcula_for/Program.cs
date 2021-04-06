using System;

namespace P11_CalculaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - calcular Poupança");

            double valorInvestidoA = 1000;
            double valorInvestidoB = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestidoA += valorInvestidoA * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses seu valor investido sera R$ " + valorInvestidoA);
            }

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestidoB *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do inestimento voce tera R$ " + valorInvestidoB);

            Console.ReadLine();
        }
    }
}
