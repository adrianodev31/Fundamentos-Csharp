using System;

namespace MediaNotas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu(){
            Console.Clear();
            Console.WriteLine("Calculadora de notas, vamos lá :D");
            Thread.Sleep(1000);
            Console.WriteLine("Digite a primeira nota: ");
            var nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            var nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            var nota3 = double.Parse(Console.ReadLine());
            var resultado = (nota1 + nota2 + nota3) / 3;
            
            if (resultado >= 7){
                Console.WriteLine($"Meus parabéns, sua média foi de '{resultado.ToString("F2")}' e você foi APROVADO!!");
            }else {
                Console.WriteLine($"Suas notas não foram suficientes infelizmente, com uma média de '{resultado.ToString("F2")}' você foi REPROVADO!! ");
            }

            Thread.Sleep(2000);
            refazer();
        }

        public static void refazer(){
            Console.WriteLine("Deseja Reiniciar o programa ?");
            Console.WriteLine("1 - Reiniciar");
            Console.WriteLine("2 - Sair");
            var opcao = int.Parse(Console.ReadLine());  
            switch(opcao){
                case 1: Menu(); break;
                case 2: System.Environment.Exit(0); break;
                default: {
                    Console.WriteLine("Encerrado o programa...") ;
                    Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    break;
                }
            }
        }
    }
}