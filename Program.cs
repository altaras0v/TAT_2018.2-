using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {
                string maxSequenceLength = MaxUniqueSequnceFinder.MaxFinderMethod(args[i]);
                Console.WriteLine("Your data: " + args[i]);
                Console.WriteLine(maxSequenceLength);
            }
        }     
    }
}
