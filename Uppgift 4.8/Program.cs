using System;
namespace Uppgift4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord");
            string ord = Console.ReadLine();
            Console.WriteLine("Skriv in två tecken du vill att programmet ska leta efter i ditt ord");
            string tecken1 = Console.ReadLine();
            string tecken2 = Console.ReadLine();

            if (ord.Contains(tecken1) && ord.Contains(tecken2))
            {
                Console.WriteLine($"{ord} innehåller {tecken1} och {tecken2}");
            }
            else if (ord.Contains(tecken1))
            {
                Console.WriteLine($"{ord} innehåller {tecken1} men inte {tecken2}");
            }
            else if (ord.Contains(tecken2))
            {
                Console.WriteLine($"{ord} innehåller {tecken2} men inte {tecken1}");
            }
            else
            {
                Console.WriteLine($"{ord} innehåller varken {tecken1} eller {tecken2}");
            }  
            Console.ReadKey();
        }
    }
}