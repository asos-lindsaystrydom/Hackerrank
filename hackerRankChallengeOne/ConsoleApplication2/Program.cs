using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int secondInteger = Int32.Parse(Console.ReadLine());
            double secondDouble = Double.Parse(Console.ReadLine());
            string secondString = Console.ReadLine();


            // Read and save an integer, double, and String to your variables.
            double doubleSum = d + secondDouble;
            
            Console.WriteLine(i + secondInteger);
            Console.WriteLine("{0:0.0}", doubleSum);
            Console.WriteLine(s + secondString);
            Console.ReadKey();
            // Print the sum of both integer variables on a new line.

            // Print the sum of the double variables on a new line.

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.

        }
    }
}
