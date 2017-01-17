using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string tempnumber;

            Console.Write("Write a number (1, 2 or 3): ");

            tempnumber = Console.ReadLine();
            number = int.Parse(tempnumber);

            if (number == 1)
            {
                Console.Write("One \n");
            }

            else if (number == 2)
            {
                Console.Write("Two \n");
            }

            else if (number == 3)
            {
                Console.Write("Three \n");
            }

            else
            {
                Console.Write("The number you inputted was not within the range \n");
            }
        }
    }
}
