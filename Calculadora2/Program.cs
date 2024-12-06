using System;

namespace Calculadora2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Menu();

        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que deseja fazer ? ");
            Console.WriteLine("");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("5 - Sair");
            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Somar(); break;
                case 2: Subtrair(); break;
                case 3: Dividir(); break;
                case 4: Multiplicar(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine($"Por favor, escolha entre 1 e 5, {escolha} não é um valor válido"); break;

            }
        }

        static void Somar (){
              Console.Clear();
            Console.WriteLine("Adiciona o primeiro Número que deseja somar: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Agora digite o número que você quer somar com {v1}");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.WriteLine($"O Resultado de {v1} + {v2} = {resultado}");
            Console.ReadKey();
            Menu();
        } 

        static void Subtrair(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro número para subtrair: ");
            float v1 = float.Parse((Console.ReadLine()));
            Console.WriteLine($"Digite o número que vc quer subtrair de {v1} : ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            Console.WriteLine($"{v1} - {v2} = {resultado}");
            Console.ReadKey (); 
            Menu();
        }

        static void Dividir(){
            Console.Clear();
            Console.WriteLine("Digite o número que você quer dividir: ");
            float v1 = float.Parse((Console.ReadLine()));
            Console.WriteLine($"Você quer dividir {v1} por quanto? : ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            Console.WriteLine($"{v1} / {v2} = {resultado}");
            Console.ReadKey (); 
            Menu();
        }
        
        static void Multiplicar(){
            Console.Clear();
            Console.WriteLine ("Digite o primeiro número que deseja multiplicar: ");
            float v1 = float.Parse((Console.ReadLine()));
            Console.WriteLine($"Você quer multiplicar {v1} por quanto ?: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.WriteLine($"{v1} x {v2} = {resultado}");
            Console.ReadKey () ;    
            Menu();
        }

    }
}