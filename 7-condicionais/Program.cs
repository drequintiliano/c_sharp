using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int acompanhantes = 2;
            bool acompanhado = acompanhantes >=2;

            if (idadeJoao > 18)
            {
                Console.WriteLine("João possui maior idade");
            }
            else
            {
                if (acompanhantes >= 2)
                {
                    Console.WriteLine("João esta acompanhado");
                }
                else
                {
                    Console.WriteLine("João não possui maior idade");
                }
            }

            if (idadeJoao > 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
