using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 100: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 != 0)
            {
                Console.WriteLine("Number {0} is Odd", Number);
            }
            else if (Number % 2 == 0 && Number >= 2 && Number <= 25)
            {
                Console.WriteLine("Number {0} is Even and less than 25", Number);
            }
            else if (Number % 2 == 0 && Number >= 26 && Number <= 60)
            {
                Console.WriteLine("Even", Number);
            }
            else if (Number % 2 == 0 && Number > 60)
            {
                Console.WriteLine("Number {0} is Even", Number);
            }
            else if (Number % 2 != 0 && Number > 60)
            {
                Console.WriteLine("Number {0} is Odd");
            }


        }
    }
}
