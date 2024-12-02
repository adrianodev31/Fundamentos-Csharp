using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Menu();             
        }

        static void Menu(){
            Console.WriteLine("Somar 1 - Subtrair 2 - Dividir 3 - Multiplicar 4 - Sair 5");
            Console.WriteLine("");
            Console.WriteLine("---------------");
            Console.WriteLine("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());
            
            switch (opcao) {
                case 1:
                Soma();
                break;

                case 2:
                Subtrair();
                break;

                case 3:
                Divisao();
                break;

                case 4:
                Multiplicacao();
                break ;

                case 5:
                Agradecimentos();
                Console.ReadKey();
                System.Environment.Exit(0);
                break;

                default:
                Console.WriteLine("Escolha 1, 2, 3 ou 4");
                Menu();
                break;
            }
        }

        static void Soma(){
            
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse( Console.ReadLine() ) ;

            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse( Console.ReadLine() ) ;

            float resultado = v1 + v2;

            Console.WriteLine($"O Resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtrair(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float v2 = float.Parse(Console.ReadLine() ) ;
            float resultado = v1 - v2;
            Console.WriteLine($"O Valor de {v1} - {v2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Digite o número que deseja dividir: ");
            float v1 = float.Parse(Console.ReadLine()) ;
            Console.WriteLine($"Deseja dividir {v1} por quanto: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            Console.WriteLine($"O Valor de {v1} dividido por {v2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Digite o numero que deseja Multiplicar: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Você gostaria de multiplicar {v1} por qual número ?: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado de {v1} x {v2} é: {resultado}");
            Console.ReadKey() ;
            Menu();
        } 
    
        static void Agradecimentos(){
            Console.Clear();
            Console.WriteLine("Obrigado por usar nosso sistema :D");
        }
    }
}