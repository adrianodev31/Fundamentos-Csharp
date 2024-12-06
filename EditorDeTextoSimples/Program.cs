using System;
using System.IO;

namespace EditorDeTextoSimples // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que você deseja fazer ?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option =  short.Parse(Console.ReadLine());

            switch (option){
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir (){
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo ?");
            string caminho = Console.ReadLine();    

            using(var file = new StreamReader(caminho)){
                string text = file.ReadToEnd();
                Console.WriteLine(text);
                Console.WriteLine("");
                Console.ReadLine();
                Menu();
            }
        }

        static void Editar (){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------------------");
            string text = "";

            do {
                text += Console.ReadLine(); 
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }
    
        static void Salvar(string text){
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo ?");

            var caminho = Console.ReadLine();
            using (var file = new StreamWriter(caminho)){        //usando o using assim, ele ja abre e fecha o arquivo pra gente, porqui ao abrir, depois ele NUNCA pode ficar aberto, tem quee fechar
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {caminho} foi salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}