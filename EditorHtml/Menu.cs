using System;

namespace EditorHtml 
{
    
        public static class Menu {
            //Somente para referência, aqui chamo as funções.
            public static void Show(){
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Red; 

                Console.WriteLine("Quantas Colunas Deseja ter na Tela ?");
                int xColunas = int.Parse(Console.ReadLine());

                DrawScreen(xColunas);
                
                WriteOptions();

                //Após executar a lista de Opções, ele fica piscado, na frene de "Opção": 
                var option = short.Parse(Console.ReadLine());

                //Aqui chamo as funções de abrir arquivo, sair, abrir
                HandleMenuOption(option);
            }


            public static void DrawScreen (int xColunas){
                //COLUNAS
                GeraColunas(xColunas);
                GeraLinhas(xColunas);
                GeraColunas(xColunas);
            }

        
            public static void WriteOptions() {
                
                //Comando coloca o cursor onde eu quiser na tela, coluna 3 linha 2
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("Editor HTML");
                Console.SetCursorPosition (3 ,3);
                Console.WriteLine("=================");
                Console.SetCursorPosition (3 ,4);
                Console.WriteLine("Selecione uma opção abaixo");
                Console.SetCursorPosition (3 ,6);
                Console.WriteLine("1 - Novo Arquivo");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("2 - Abrir");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("0 - Sair");
                Console.SetCursorPosition(3, 10);
                Console.Write("Opção: ");
            }

            //Menu da aplicação, os cases, resposta do usuário e ação.
            public static void HandleMenuOption (short option){
                switch(option){
                    case 1: Editor.Show(); break;
                    case 2: Console.WriteLine("View"); break;
                    case 0: {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                    default: Show(); break;
                }
            }


            static void GeraColunas(int numeroDeColunas){
                Console.Write("+");

                    for(int i = 0; i <= numeroDeColunas; i++) 
                        Console.Write("-");
                    
                    Console.Write("+");
                    Console.Write("\n");
            }

            static void GeraLinhas (int xLinhas){
                   for(int lines = 0; lines <= 10; lines ++){
                    Console.Write("|");
                    for(int i = 0; i <= xLinhas; i++){
                        Console.Write(" ");
                    }
                     Console.Write("|");
                     Console.Write("\n");
                }
            }

        }
    




}