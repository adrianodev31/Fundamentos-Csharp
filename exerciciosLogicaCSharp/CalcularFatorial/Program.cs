using System;

namespace CalcularFatorial // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Calcula Fatorial");
            Console.WriteLine("2 - Sair");
            var opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: CalculaFatorial(); break;
                case 2: System.Environment.Exit(0); break;
                default:
                    {
                        Console.WriteLine("Opção Inválida!!");
                        Thread.Sleep(2000);
                        Menu();
                        break;
                    }
            }
        }

        private static void CalculaFatorial()
        {
            Console.Clear();
            Console.WriteLine("Você quer o Fatorial de qual número?: ");
            var fatorialNum = int.Parse(Console.ReadLine());
            Console.Write($"{fatorialNum}! = {fatorialNum}");

            int resultado = fatorialNum;
            for (int i = fatorialNum; i > 1; i--)
            {
                Console.Write($" x {i - 1}");
                resultado *= (i - 1);
            };

            Console.Write($" = {resultado}");
            Thread.Sleep(3000);
            Menu();
        }
    }
}