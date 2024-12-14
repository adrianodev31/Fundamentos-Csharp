using System;

namespace taboadaDeUmNumero // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Menu();            
        }


        public static void Menu()
        {   Console.Clear();
            Console.WriteLine("Gostaria de ver a taboada de qual número ?: ");
            var numeroDigitado = int.Parse(Console.ReadLine());
            taboada(numeroDigitado);
        }

        public static void taboada(int numeroDigitado){
            Console.WriteLine(" ");
            for(int i = 0; i <= 10; i++){
                Console.WriteLine($"{numeroDigitado} x {i} = {numeroDigitado*i}");
            }
            Console.WriteLine("");
            Thread.Sleep(2000);
            
            Console.WriteLine("Deseja refazer ?");
            Console.WriteLine("1 - Refazer");
            Console.WriteLine("2 - Sair");
            var opcaoRefazer = int.Parse(Console.ReadLine());   
            if(opcaoRefazer == 1){
                Console.Clear();
                Menu();
            }else if(opcaoRefazer == 2){
                System.Environment.Exit(0);
            }else {
                Console.WriteLine("Número inválido, encerrando o programa em");
                Thread.Sleep(1000);
                Console.WriteLine("3");
                Thread.Sleep(1000);
                Console.WriteLine("2");
                Thread.Sleep(1000);
                Console.WriteLine("1");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
    }
}