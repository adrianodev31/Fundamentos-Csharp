using System;

namespace ParOuImpar // Note: actual namespace depends on the project name.
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
            Console.WriteLine("1 - Fazer teste par ou impar");
            Console.WriteLine("2 - Sair!");
            var respostaUser = int.Parse(Console.ReadLine());

            switch (respostaUser)
            {
                case 1: testeParOuImpar(); break;
                case 2: System.Environment.Exit(0); break;
                default:
                    {
                        Console.WriteLine("Comando Inválido, escolha 1 para refazer ou 2 para sair!");
                        Thread.Sleep(3000);
                        Menu();
                        ; break;
                    }
            }
        }

        public static void testeParOuImpar()
        {
            Console.Clear();
            Console.WriteLine("Digite um número e te digo se é par ou impar ?: ");
            var numeroDigitado = int.Parse(Console.ReadLine());
            if (numeroDigitado % 2 == 0)
            {
                Console.WriteLine("Par");
                Thread.Sleep(2000);
                Menu();
            }
            else if (numeroDigitado % 2 == 1)
            {
                Console.WriteLine("Impar");
                Thread.Sleep(2000);
                Menu();
            }
        }
    }
}