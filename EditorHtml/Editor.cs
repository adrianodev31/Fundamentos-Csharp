using System;
using System.Text;

namespace EditorHtml {
    //classe Editor
    public static class Editor {

        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("=====================");
            Start();
        }

        public static void Start(){
            var file = new StringBuilder();
            

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("=====================");
            Console.WriteLine("Deseja Salvar o arquivo ?");
            Salvar(file.ToString());
        }

        public static void Salvar (string file) {
            Console.Clear();
            Console.WriteLine("Qual caminho deseja salvar o arquivo ?");
            string caminho = Console.ReadLine();
            using(var arquivo = new StreamWriter(caminho)) {
                arquivo.Write(file);
            }
            Viewer.Show(file.ToString());

            Menu.Show();
        }
    }
}