using System;

namespace SameLetter
{
    /// <summary>
    /// Program that counted and displayed same letters in string that user entered in command line
    /// </summary>
    class ProgramSameLettersFinder
    {
        /// <summary>
        /// Entry point of programm
        /// </summary>
        /// <param name="args"> Number(args[0]) is string that user entered </param>
        static void Main(string[] args)
        {
            try
            {
                SameLettersFinder s = new SameLettersFinder();
                SameLettersDisplayer displayer = new SameLettersDisplayer();
                displayer.DisplaySameLetter(s.GetSameLetters(args[0]));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
        }
        
    }
}