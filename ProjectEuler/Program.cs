using System;

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

            switch (problemSelection)
            {
                default:
                    Console.WriteLine("not yet implemented");
                    break;
            }

            Console.ReadKey();
        }
    }
}
