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
            var primeNumbers = new PrimeNumbers();
            var factorizationCache = new FactorizationCache(primeNumbers);
            var numberWordGenerator = new NumberWordGenerator();

            switch (problemSelection)
            {
                case 1:
                    problem = new Problem1(1000);
                    break;
                case 2:
                    problem = new Problem2(4000000);
                    break;
                case 3:
                    problem = new Problem3(600851475143, primeNumbers);
                    break;
                case 4:
                    problem = new Problem4(3);
                    break;
                case 5:
                    problem = new Problem5(20, primeNumbers);
                    break;
                case 6:
                    problem = new Problem6(100);
                    break;
                case 7:
                    problem = new Problem7(10001, primeNumbers);
                    break;
                case 8:
                    problem = new Problem8(13);
                    break;
                case 9:
                    problem = new Problem9();
                    break;
                case 10:
                    problem = new Problem10(2000000, primeNumbers);
                    break;
                case 11:
                    problem = new Problem11();
                    break;
                case 12:
                    problem = new Problem12(factorizationCache, 500);
                    break;
                case 13:
                    problem = new Problem13();
                    break;
                case 14:
                    problem = new Problem14();
                    break;
                case 15:
                    problem = new Problem15(20);
                    break;
                case 16:
                    problem = new Problem16(1000);
                    break;
                case 17:
                    problem = new Problem17(1000, numberWordGenerator);
                    break;
                case 18:
                    problem = new Problem18(Problem18.GetTriangleForProblem18());
                    break;
                case 19:
                    problem = new Problem19();
                    break;
                case 20:
                    problem = new Problem20(100);
                    break;
                case 21:
                    problem = new Problem21(factorizationCache);
                    break;
                case 22:
                    problem = new Problem22();
                    break;
                case 23:
                    problem = new Problem23(factorizationCache);
                    break;
                case 24:
                    problem = new Problem24(10, 1000000);
                    break;
                case 25:
                    problem = new Problem25(1000);
                    break;
                case 67:
                    problem = new Problem18(Problem18.GetTriangleForProblem67());
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
