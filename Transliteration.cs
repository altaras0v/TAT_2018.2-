using System;
using System.Text;

namespace ConsoleApp3
{
    class Transliteration
    {
        static void Main(string[] args)

        {
            try
            {
                Transliteration EntryPointObject = new Transliteration();
                string inputString = args.ArrayToString();  
                TransliterationDeciders entryTransliteration = new TransliterationDeciders();
                entryTransliteration.AutomaticTransliteration(ref inputString);
                Console.WriteLine("Your data: " + inputString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
