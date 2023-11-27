using System;

namespace Aufgabe4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Welches Jahr soll überprüft werden: ");
            int input = Convert.ToInt16(Console.ReadLine());
            if ((input % 400 == 0.0 || input % 4 == 0.0) && input % 100 != 0.0) 
            {
                Console.WriteLine("Es handelt sich um ein Schaltjahr");
            }
            else
            {
                Console.WriteLine("Es handelt sich nicht um ein Schaltjahr");
            }
        }
    }
}