using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    /// <summary>
    /// Class that accepts a string in Cyrillic or in Latin,
    /// converts the string to lower case, and transliterate to Latin or Cyrillic
    /// </summary>
    class TransliterationDeciders
            {
                /// <summary> 
                /// function for determine from which language to which we will transliteration the string
                /// </summary> 
                /// <param name="stringArgument"
                /// >String, which was inputed
                /// </param>
                public void AutomaticTransliteration(ref String stringArgument)
                    {
                        string checkString = String.Copy(stringArgument);
                        checkString = String.Concat(checkString.OrderBy(c => c));
                        checkString = checkString.Replace(" ", string.Empty);
                        // check Cyrillic
                        if (Enumerable.Range(1072, 1103).Contains(checkString[0]) && (Enumerable.Range(1072, 1103).Contains(checkString[checkString.Length - 1])))
                            {
                                CyrillicToLatinTransliteration(ref stringArgument);
                            }
                        //checkLatin
                        else if (Enumerable.Range(97, 122).Contains(checkString[0]) && (Enumerable.Range(97, 122).Contains(checkString[checkString.Length - 1])))
                            {
                                LatinToCyrillicTransliteration(ref stringArgument);
                            }
                        else
                        {
                                Console.WriteLine("The string must contain only Russian or English letters");
                                System.Environment.Exit(0);
                            }
                    }
                                /// <summary> 
                /// Method CyrillicToLatinTransliteration
                        /// Function for transliteration string from cyrillic to latin
                                /// </summary> 
                                        /// <param name="stringArgument">String, which was inputed</param>

        static void CyrillicToLatinTransliteration(ref String stringArgument)
                    {
                        StringBuilder transliteratedString = new StringBuilder();
                        transliteratedString.Append(stringArgument);
                        Dictionary<string, string> cyrillicToLatinDictionary = new Dictionary<string, string>
                        {

                        ["а"] = "a",
                        ["б"] = "b",
                                ["в"] = "v",
                        ["г"] = "g",
                        ["д"] = "d",
                        ["е"] = "e",
                        ["ё"] = "yo",
                        ["ж"] = "zh",
                        ["з"] = "z",
                        ["и"] = "i",
                        ["й"] = "y",
                        ["к"] = "k",
                        ["л"] = "l",
                        ["м"] = "m",
                        ["н"] = "n",
                        ["о"] = "o",
                        ["п"] = "p",
                        ["р"] = "r",
                        ["с"] = "s",
                        ["т"] = "t",
                        ["у"] = "u",
                        ["ф"] = "f",
                        ["х"] = "kh",
                        ["ц"] = "ts",
                        ["ч"] = "ch",
                        ["ш"] = "sh",
                        ["щ"] = "sch",
                        ["ъ"] = "",
                        ["ы"] = "y",
                        ["ь"] = "",
                        ["э"] = "e",
                        ["ю"] = "yu",
                        ["я"] = "ya"
                        };
                            foreach (string i in cyrillicToLatinDictionary.Keys)
                            {
                            transliteratedString.Replace(i, cyrillicToLatinDictionary[i]);
                            }
                            stringArgument = transliteratedString.ToString();
                    }
                 /// <summary> 
                 /// Transliteration string from latin to cyrillic
                 /// </summary> 
                 /// <param name="stringArgument">String, that was inputed</param>

        static void LatinToCyrillicTransliteration(ref String stringArgument)
        {
                        StringBuilder transliteratedString = new StringBuilder();
                        transliteratedString.Append(stringArgument);
                        Dictionary<string, string> cyrillicToLatinDictionary = new Dictionary<string, string>
            {                            
                ["a"] = "а",
                ["b"] = "б",
                ["v"] = "в",
                ["g"] = "г",
                ["d"] = "д",
                ["e"] = "е",
                ["z"] = "з",
                ["i"] = "и",
                ["k"] = "к",
                ["l"] = "л",
                ["m"] = "м",
                ["n"] = "н",
                ["o"] = "о",
                ["p"] = "п",
                ["r"] = "р",
                ["s"] = "с",
                ["t"] = "т",
                ["u"] = "у",
                ["f"] = "ф",
                ["y"] = "ы",
                ["sch"] = "щ",
                ["sh"] = "ш",
                ["yo"] = "ё",
                ["yu"] = "ю",
                ["ya"] = "я",
                ["kh"] = "х",
                ["ts"] = "ц",
                ["ch"] = "ч",
                ["zh"] = "ж",
            };

            foreach (string i in cyrillicToLatinDictionary.Keys)
            {
                transliteratedString.Replace(i, cyrillicToLatinDictionary[i]);
            }
            stringArgument = transliteratedString.ToString();
        }
    }
}