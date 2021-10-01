using System;
using System.Collections.Generic;
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
           
        }

        static string ToPigLatin(string sentence)
        {

            const string vowels = "aeiou";
            List<string> pigWords = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    pigWords.Add(restOfWord + firstLetter + "ay");
                }
                else
                {
                    pigWords.Add(word + "way");
                }
            }
            return string.Join(" ", pigWords);
        }

        
    }
}
