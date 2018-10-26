using System;

namespace RadixConverter
{
    /// <summary>
    /// Program that converts number from one numeral system to another
    /// Number and new base of new numeral system entered by user
    /// Minimum base of new numeral system is 2, maximum is 20
    /// </summary>
    class ProgramRadixConverter
    {
        /// <summary>
        /// Entry point of programm
        /// </summary>
        /// <param name="args"> Number(args[0]) and base of new numeral system(args[1]) that user entered </param>
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(args[0]);
                int newBase = int.Parse(args[1]);
                int minimumBase = 2;
                int maximumBase = 20;
                if (newBase < minimumBase || newBase > maximumBase)
                {
                    Console.WriteLine("Numeric base is wrong");
                }
                CoverterToNewSystem newConverter = new CoverterToNewSystem();

                string covertedNumber = newConverter.ToNewBaseConverter(number, newBase);
                if (number < 1)                                                             // If user entered a negative number, added minus to result
                {
                    Console.WriteLine("-" + covertedNumber);                   
                }
                else
                {
                    Console.WriteLine(covertedNumber);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
        }
    }
}