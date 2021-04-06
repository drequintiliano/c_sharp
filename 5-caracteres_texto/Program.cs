using System;

namespace _5_CaracteresTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e Texto");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "alura cursos de tecnologia";
            Console.WriteLine(titulo);

            string  cursos = 
                @" - .NET
                   - Java
                   - NodeJS";
            Console.WriteLine(cursos);

            Console.WriteLine("A execução acabou, tecle enter para fechar...");
            Console.ReadLine();
        }
    }
}
