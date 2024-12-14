using System;

namespace NumeroMaiorEMenor 
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Menu();
        }

        public static void Menu() {
            Console.Clear();
            Console.WriteLine("Numero 1: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            var numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 3: ");
            var numero3 = int.Parse(Console.ReadLine());

            if( numero1 > numero2 && numero2 > numero3){
                Console.WriteLine($"O Numero {numero1} é o maior e o numero {numero3} é o menor!");
            } else if(numero1 > numero3 && numero2 < numero3){
                Console.WriteLine($"O Numero {numero1} é o maior, e o numero {numero2} é o menor!");
            } else if(numero1 < numero2 && numero2 < numero3){
                Console.WriteLine($"O Numero {numero3} é o maior, e o numero {numero1} é o menor!");
            } 

            Thread.Sleep(1000);
            Console.WriteLine("1 - Refazer o teste");
            Console.WriteLine("2 - Sair");
            var resposta = int.Parse(Console.ReadLine());   

            if(resposta == 1){
                Menu();
            }else {
                System.Environment.Exit(0);
            }
        }
    }
}