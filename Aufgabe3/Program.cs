using System;

namespace Aufgabe3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Welche Zahl soll überprüft werden: ");
            int input = Convert.ToInt16(Console.ReadLine());
            if ((input > 0 && input < 40) || input == 42) 
            {
                Console.WriteLine("Die Zahl liegt zwischen 0 und 40 oder hat den Wert 42.");
            }
            else
            {
                Console.WriteLine("Die Zahl erfüllt die Anforderungen nicht");
            }
        }
    }
}