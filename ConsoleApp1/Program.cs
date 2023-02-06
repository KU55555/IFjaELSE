using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maja suurus");
            Console.WriteLine("Palun sisestage oma maja suurus: ");
            string pikkus = Console.ReadLine();
            int pikkusParse = Int16.Parse(pikkus);

            Console.WriteLine("Sinu maja suurus on " + pikkusParse);
            Console.ReadKey();
            if (pikkusParse >= 0 && pikkusParse <= 40)
            {
                Console.WriteLine("Sinu maja on vaike");
            }
            else if (pikkusParse >= 41 && pikkusParse <= 90)
            {
                Console.WriteLine("Sinu maja on keskmise suurusega");
            }
            else if (pikkusParse >= 91 && pikkusParse <= 130)
            {
                Console.WriteLine("Sinu maja on vaga suur");
            }
            else if (pikkusParse >= 131)
            {
                Console.WriteLine("Sinu maja on vaga vaga suur");
            }
            else
            {
                Console.WriteLine("Error, maja pikkus oli valesti sisestatud või ei vastanud programmi tingimustele");
            }
        }
    }
}