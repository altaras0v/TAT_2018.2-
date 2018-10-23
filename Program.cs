using System;

namespace ConsoleApp2
{
    /// <summary>
    /// Program that countes the maximum length of consecutive non-repeating elements
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point of programm 
        /// </summary>
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
