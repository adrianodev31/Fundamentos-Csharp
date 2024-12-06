using System;

namespace EditorDeTextoSimples2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu (){
            Console.Clear();
            Console.WriteLine("O que você deseja fazer ?");
            Console.WriteLine("1 - Abrir um arquivo");
            Console.WriteLine("2 - Editar um arquivo");
            Console.WriteLine("0 - Sair");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao){
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar (); break;
                default: Menu(); break;
            }
        }

        static void Editar (){
            Console.Clear();    
            Console.WriteLine ("Digite o que desejar:");
            Console.WriteLine ("-------------------------");
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
            Console.WriteLine("Qual caminho deseja salvar o arquivo ?");
            string caminho = Console.ReadLine();
            using(var file = new StreamWriter(caminho)){
                file.Write(text);
            }

            Console.WriteLine($"O caminho escolhido foi: {caminho}");
            Console.ReadLine();
            Menu();
        }

        static void Abrir (){
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo que deseja abrir ?");
            string caminho = Console.ReadLine ();

            using(var file = new StreamReader(caminho)  ){
                string text = file.ReadToEnd();
                Console.WriteLine(text);
                Console.WriteLine("");
                Console.ReadLine ();    
                Menu();
            }

        }
       

    }
}