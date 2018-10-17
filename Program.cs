using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If your data is more than one word, please use quotes \" \"\n");
            for (int i = 0; i < args.Length; i++)
            {   
                Console.WriteLine("Your data: "+ args[i]);
                char[] myString = args[i].ToCharArray();                                        //array of each parameters
                ArrayList nonRepeatingSymbols = new ArrayList();                                
                int maxLength = 0;
   
                for (int n = 0; n < myString.Length; n++)
                {
                    nonRepeatingSymbols.Add(myString[n]);

                    for (int k = n + 1; k < myString.Length && !(nonRepeatingSymbols.Contains(myString[k]));k++)
                    {
                        nonRepeatingSymbols.Add(myString[k]);

                        if (nonRepeatingSymbols.Count > maxLength)
                        {
                            maxLength = nonRepeatingSymbols.Count;
                        }
                     }
                    nonRepeatingSymbols.Clear();
                    }
                     Console.WriteLine("Maximum number of consecutive non-repeating elements is: " + maxLength);
                }   
            } 
        }
    }