using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Multiplier";
            Console.WindowHeight = 50;
            Console.ForegroundColor = ConsoleColor.Green;
            double num01;
            double num02;
            Console.Write("Input No1 ");
            num01 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Input a second number ");
            num02 = Convert.ToDouble(Console.ReadLine() );
            double answer = num01 * num02;
            Console.WriteLine("The answer is " + answer);
            

















            

            Console.ReadKey();
            
        }
    }
}
