using System;
using Common;
using Problems;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int problemSelection;

            do
            {
                Console.WriteLine("Select problem:");
                var line = Console.ReadLine();

                if (int.TryParse(line, out problemSelection) && problemSelection >= 1) 
                    continue;

                Console.WriteLine("invalid input");
                problemSelection = -1;
            } while (problemSelection < 1);

            IProblem problem;

            switch (problemSelection)
            {
                case 1:
                    problem = new Problem1(1000);
                    break;
                case 2:
                    problem = new Problem2(4000000);
                    break;
                case 3:
                    problem = new Problem3(600851475143, new PrimeNumbers());
                    break;
                case 4:
                    problem = new Problem4(3);
                    break;
                case 5:
                    problem = new Problem5(20, new PrimeNumbers());
                    break;
                case 6:
                    problem = new Problem6(100);
                    break;
                case 7:
                    problem = new Problem7(10001, new PrimeNumbers());
                    break;
                case 8:
                    problem = new Problem8(13);
                    break;
                default:
                    Console.WriteLine("not yet implemented");
                    Console.ReadKey();
                    return;
            }

            var result = problem.Solve();
            Console.WriteLine("result: " + result);
            Console.ReadKey();
        }
    }
}
