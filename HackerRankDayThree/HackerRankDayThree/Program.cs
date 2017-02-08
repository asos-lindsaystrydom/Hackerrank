using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDayThree
{
    class Program
    {
       

        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        static void Main(string[] args)
        {

            int n = Int32.Parse(Console.ReadLine());

            if (n >= 1 && n <= 100)
            {

                

                if (IsEven(n) && n >= 2 && n <= 5 || IsEven(n) && n > 20)
                {
                    Console.WriteLine("Not Weird");
                }
                else
                {
                    Console.WriteLine("Weird");
                }

                
            }

        }
    }
}
