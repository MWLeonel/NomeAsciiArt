using System;
using Figgle;

namespace NomeAsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            string SeuNome;

            Console.Write("Digite seu nome: ");
            SeuNome = FiggleFonts.Basic.Render(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("Seu nome usando figgle é assim");
            Console.Write("\n");
            Console.WriteLine(SeuNome);

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
