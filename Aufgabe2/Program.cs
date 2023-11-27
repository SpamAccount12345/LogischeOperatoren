using System;

namespace Aufgabe2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OR    | true  | false");
            Console.WriteLine("true  | {0,5} | {1,5}", (true && true), (false && true));
            Console.WriteLine("false | {0,5} | {1,5}", (true && false), (false && false));
        }
    }
}