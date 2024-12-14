using System;

namespace SomaDeNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Add um numero para somar: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora Digite o segundo numero que deseja somar ?");
            var numero2 = int.Parse(Console.ReadLine());
            var resultado = numero1 + numero2;
            Console.WriteLine($"O resultado da soma entre {numero1} e {numero2} é = {resultado}");

        }
    }
}