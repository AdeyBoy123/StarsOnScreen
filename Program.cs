using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsOnScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the pyramid:");
            int height;
            if (int.TryParse(Console.ReadLine(), out height))
            {
                DrawPyramid(height);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        static void DrawPyramid(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                // Print spaces
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
