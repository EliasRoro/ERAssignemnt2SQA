using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAssignemnt2SQA
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            List<int> sides = new List<int>();

            while (menu != 2)
            {
                Console.Clear();
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit\n");

                while (!int.TryParse(Console.ReadLine(), out menu) || menu <= 0 || menu > 2)
                {
                    Console.WriteLine("\nEnter a Right Number!");
                }
                Console.WriteLine();

                int result = 0;
                switch (menu)
                {
                    case 1:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Enter number {i}:");

                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out result))
                                {
                                    sides.Add(result);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("It must be a positive integer!");
                                    Console.WriteLine("Re-enter integer");
                                }
                            }
                        }
                        Console.WriteLine(TriangleClass.Analyze(ref sides));
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }

        }
    }
    
}
