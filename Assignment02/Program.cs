using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables to be used
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;
            int input;
            string result;
            bool cont = false;

            Console.WriteLine("Welcome");
            do
            {
                // exception handling
                try
                {
                    Console.WriteLine("1. Enter triangle dimensions\n");
                    Console.WriteLine("2. Exit");
                    input = int.Parse(Console.ReadLine());

                    // multiple choice cases
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Please specify side1 of Triangle\n");
                            side1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please specify side2 of Triangle\n");
                            side2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please specify side3 of Triangle\n");
                            side3 = int.Parse(Console.ReadLine());
                            // directly accessing the trianglesolver method without even creating an object
                            result = TriangleSolver.Analyze(side1, side2, side3);
                            Console.WriteLine(result);
                            cont = true;
                            break;
                        case 2:
                            Environment.Exit(0);
                            cont = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input!");
                            cont = true;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    cont = true;
                }
            } while (cont == true);
        }
    }
}
