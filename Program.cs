using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;
            Console.Write("Enter an odd number (above 11) for an arrow up shape: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Please enter an odd number for a better arrow shape.");
            }
            else
            {
                int middle = n / 2 + 1;

                for (int i = 1; i <= middle; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j >= middle - i + 1 && j <= middle + i - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("_");
                        }
                    }
                    Console.WriteLine();
                }

                for (int i = 1; i <= ((n - 1) / 2); i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j >= middle - (((n - 1) / 2) / 2) && j <= middle + (((n - 1) / 2) / 2))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("_");
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
