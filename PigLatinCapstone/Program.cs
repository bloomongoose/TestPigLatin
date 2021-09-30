using System;
using System.Linq;

namespace PigLatinCapstone
{
    class Program
    {
        static void Main(string[] args)
        {         
            //Getting user input
            
            Console.WriteLine("Welcome to the PigLatinator. Enter a word: ");
            string input = Console.ReadLine();
            Console.WriteLine(ToPigLatin(input));
            //Console.WriteLine(FirstLetterSeperator(input));
            
        }


        public static string ToPigLatin(string sentencetext)
        {
            string vowels = "AEIOUaeiou";
            string cons = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            Func<string, string> toPigLatin = word =>
            {
                word = word.ToLower();

                var result = word;

                Func<string, string, (string, string)> split = (w, l) =>
                {
                    var prefix = new string(w.ToArray().TakeWhile(x => l.Contains(x)).ToArray());
                    return (prefix, w.Substring(prefix.Length));
                };

                if (!word.Any(w => cons.Contains(w)))
                {
                    result = word + "way";
                }
                else
                {
                    var (s, e) = split(word, vowels);
                    var (s2, e2) = split(e, cons);
                    result = e2 + s + s2 + "ay";
                }
                return result;
            };

            return string.Join(" ", sentencetext.Split(' ').Select(x => toPigLatin(x)));
        }



        //static string ToPigLatin(string sentence)
        //{

        //    const string vowels = "AEIOUaeio";
        //    List<string> pigWords = new List<string>();

        //    foreach (string word in sentence.Split(' '))
        //    {
        //        string firstLetter = word.Substring(0, 1);
        //        string restOfWord = word.Substring(1, word.Length - 1);
        //        int currentLetter = vowels.IndexOf(firstLetter);

        //        if (currentLetter == -1)
        //        {
        //            pigWords.Add(restOfWord + firstLetter + "ay");
        //        }
        //        else
        //        {
        //            pigWords.Add(word + "way");
        //        }
        //    }
        //    return string.Join(" ", pigWords);
        //}

        //This method separates the first letter 
        //public static string FirstLetterSeperator(string x)
        //{
        //    string firstLetter = x.Substring(0, 1);
        //    return firstLetter;
        //}

        //public static bool VowelChecker(bool x)
        //{

        //    if (x.Equals = "a")
        //    {

        //    }



        //}
    }
}
