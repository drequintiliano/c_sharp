using System;

namespace _4_ConversoesTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversões Tipo Numericos");

            double salarioDouble;
            salarioDouble = 5900.40;
            int salarioInt;
            salarioInt = (int)salarioDouble;
            Console.WriteLine(salarioInt);

            // o Long é uma variavel de 64bits
            long idadeUniverso;
            idadeUniverso = 13000000000;
            Console.WriteLine(idadeUniverso);

            // o short é um tipo de variavel de 16bits
            short quantidadeProdutos;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("A execução acabou, tecle enter para fechar...");
            Console.ReadLine();
        }
    }
}
