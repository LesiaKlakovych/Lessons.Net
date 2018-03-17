using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter natural number");
                string text = Console.ReadLine();

                uint number=Task1.ParseNaturalFromString(text);
                if (Task1.AreDigitsDifferent(number) == true)
                {
                    Console.WriteLine("All digits in the number are different");
                }
                else
                {
                    Console.WriteLine("Not all digits in the number are different");
                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}
