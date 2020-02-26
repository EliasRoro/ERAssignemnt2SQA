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
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int menu = 0;
            List<int> sides = new List<int>();

            while (menu != 2)
            {
                Console.Clear();
                Console.WriteLine("1.Press 1 to Enter triangle dimensions");
                Console.WriteLine("2. Press 2 To Exit program\n");

                while (!int.TryParse(Console.ReadLine(), out menu) || menu <= 0 || menu > 2)
                {
                    Console.WriteLine("\nEnter a Right Number!");
                }
                Console.WriteLine();
                switch (menu)
                {
                    case 1:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Enter number {i}:");

                            while (true)
                            {

                                if (int.TryParse(Console.ReadLine(), out int result))
                                {
                                    sides.Add(result);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter positive integer!");
                                    Console.WriteLine("Enter integer");
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
