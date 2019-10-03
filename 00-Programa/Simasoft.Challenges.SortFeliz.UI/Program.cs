using System;
using Simasoft.Challenges.SortFeliz.UI.Numeros;

namespace Simasoft.Challenges.SortFeliz.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Questão 1 - Números Felizes e Sortudos");                                
            int numeroValidar = 0;                   
            
            while(true)
            { 
                Console.WriteLine("");
                Console.WriteLine("Entre um número para validar ou 999 para sair: ");
                string numeroInput = Console.ReadLine();

                if(numeroInput == "999")
                    break;

                if(int.TryParse(numeroInput, out numeroValidar))
                {
                    Console.WriteLine("---");
                    Console.WriteLine(new SortudoEFeliz(numeroValidar).ImprimeResultadoGeral());
                    Console.WriteLine("---");
                    Console.WriteLine("Pressione algo para recomeçar.");
                    Console.ReadKey();
                    Console.Clear();
                }else{
                    Console.WriteLine("ERRO! NÚMERO INVÁLIDO!");
                    Console.WriteLine("Pressione algo para recomeçar.");
                    Console.ReadKey();  
                    Console.Clear();                  
                }
                
            }            
        }
    }
}
