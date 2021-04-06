using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 16;
            int acompanhantes = 2;
            bool acompanhado = acompanhantes >= 2;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João esta companhado";
            }
            else
            {
                mensagemAdicional = "João não esta acompanhado";
            }

            if (idadeJoao > 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar" + mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
