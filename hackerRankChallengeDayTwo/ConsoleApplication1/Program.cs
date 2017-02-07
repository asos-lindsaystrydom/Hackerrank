using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = Double.Parse(Console.ReadLine());
            double tipPercent = Convert.ToDouble(Int32.Parse(Console.ReadLine()));
            double taxPercent = Convert.ToDouble(Int32.Parse(Console.ReadLine()));


            double tipAmount = mealCost * tipPercent / 100;

            

            double taxAmount = mealCost * taxPercent / 100;

            
        

            int totalCost = (int)Math.Round(mealCost + tipAmount + taxAmount);

            

            Console.WriteLine("The total meal cost is " + totalCost + " dollars");
            Console.ReadKey();
        }
    }
}
