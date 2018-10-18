using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("If your data is more than one word, please use quotes \" \"\n");

            for (int i = 0; i < args.Length; i++)
            {
                string maxSequenceLength = MaxUniqueSequnceFinder.MaxFinderMethod(args[i]);
                Console.WriteLine("Your data: " + args[i]);
                Console.WriteLine(maxSequenceLength);
            }
        }     
    }
}