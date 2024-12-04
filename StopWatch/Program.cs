using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class StopWatch
    {
        static void Main(string[] args)
        {   
            Menu();
        }

        static void Menu (){
            Console.Clear();
            Console.WriteLine("Você quer que conte até quanto ?");
            Console.WriteLine("ex: 20s = 20 Segundos");
            Console.WriteLine("ex: 30m = 30 Minutos");
            Console.WriteLine();
            string digitado = Console.ReadLine().ToLower();
            char tipo = char.Parse(digitado.Substring(digitado.Length - 1 , 1 ));
            int contador = int.Parse(digitado.Substring(0, digitado.Length - 1));
         
            Thread.Sleep(1000);
            PreStart(contador, tipo);
        }


        static void PreStart (int contador, char tipo){
            Console.WriteLine("Preparado ?");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("3...");
           
            Thread.Sleep(500);
             Console.Clear();
            Console.WriteLine("2...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("1...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("vaaaai");
            Thread.Sleep(500);
            Console.Clear();
            Cronometro(contador, tipo);
        }

        static void Cronometro (int contador, char tipo){
            
            int contadorWhile = 0;
          
                if(tipo == 'm'){
                    while (contadorWhile <= contador ){
                        for(int i = 1; i <= 60; i++){
                                Console.Clear();
                                Console.WriteLine($"{i}");
                                Thread.Sleep(1000);
                        }


                        contadorWhile++;
                    }
                    Console.Clear();
                    Console.WriteLine($"Muito bem, contamos {contador} minutos");
                    
                }
                else
                {
                    while (contadorWhile <= contador)
                    {
                        Console.Clear();
                        Console.WriteLine($"{contadorWhile}");
                        Thread.Sleep(1000);
                        contadorWhile++;
                    }

                }


            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine($"Deseja contar novamente ?");
            Console.WriteLine($"1 - Sair");
            Console.WriteLine($"2 - Sim, contar novamente");
            int resposta = int.Parse(Console.ReadLine());   
            if(resposta == 1){
                System.Environment.Exit(0);
            }else {
                Console.Clear();
                Menu();
            }
           
          
        }

    }
}