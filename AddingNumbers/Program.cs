using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_1 , number_2;

            Console.WriteLine("Number addition: ");

            Console.Write("Enter a 1st number - ");
            if (! Int32.TryParse( Console.ReadLine() , out number_1))
            {
                Console.Write("Conversion to number did not succeed. Zero to be assigned ");
                number_1 = 0;
            }

            Console.Write("Enter a 2nd number - ");
            if (!Int32.TryParse(Console.ReadLine(), out number_2))
            {
                Console.Write("Conversion to number did not succeed. Zero to be assigned ");
                number_2 = 0;
            }

            int sum_of_numbers = number_1 + number_2;
            Console.WriteLine("Sum = " + sum_of_numbers);
            Console.ReadLine();
        }
    }
}
