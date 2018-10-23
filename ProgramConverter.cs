using System;

namespace Task3
{
    /// <summary>
    /// Program that converts number from one numeral system to another
    /// </summary>
    class ProgramConverter
    {
        /// <summary>
        /// Entry point of programm 
        /// </summary>
        /// <param name="args">Two arguments (Integer number and new numeral base) from command line 
        /// that entered by user </param>
        static void Main(string[] args)
        {
           try
           {
               int newBase = int.Parse(args[1]);                                            
               if (newBase < 2 || newBase > 20)                                               //Сhecking range of the base of a new number system
               {
                    Console.WriteLine(("Error in base of numeral system."));
               }
                RadixConverter convertNumber = new RadixConverter();
                Console.WriteLine(convertNumber.Converter(args[0],newBase));
           }
           catch (FormatException)
           {
              Console.WriteLine("You need to write an integer number");
           }
           
           catch (Exception ex)
           {
                Console.WriteLine("Exception: " + ex.Message);
           }         
        }
    }
}
