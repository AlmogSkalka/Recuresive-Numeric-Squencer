using System;

namespace ConsoleApp2
{
    class Program
    {
        int maximum = int.MaxValue;
        int counter = 0;

        int ReadNextNumber()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                return n;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input. Numbers only." + e);
                return ReadNextNumber();
            }
        }

        void ProcessStream(int nextNumber)
        {
            if (nextNumber == 0)
            {
                Console.WriteLine("Counter: "+counter);
                return;
            }

            if (nextNumber < maximum)
            {
                maximum = nextNumber;
                counter = 1;
            }
            else if (nextNumber == maximum)
            {
                counter++;
            }

            ProcessStream(ReadNextNumber());
        }

        static void Main()
        {
            Program prog = new Program();
            prog.ProcessStream(prog.ReadNextNumber());
            //used to avoid statics for the funcs readnextnum and processStrean
        }

    }
}
