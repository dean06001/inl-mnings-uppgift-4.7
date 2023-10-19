using System;
namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande");
            string meddelande = Console.ReadLine();
            Console.WriteLine("Hur mång steg till höger ska meddelandet flyttas?");
            int steg = int.Parse(Console.ReadLine());
            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }
            Console.ReadKey();
        }
    }
}