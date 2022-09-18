using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_making
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 1; row <= height; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(number);

                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
 
