using System;

namespace PigLatinCapstone
{
    class Program
    {
        static void Main(string[] args)
        {         
            //Getting user input
            
            Console.WriteLine("Welcome to the PigLatinator. Enter a word: ");
            string input = Console.ReadLine();
            Console.WriteLine(FirstLetterSeperator(input));
            
        }


        
        public static string FirstLetterSeperator(string x)
        {
            string firstLetter = x.Substring(0, 1);
            return firstLetter;
        }
        //public static bool VowelChecker(bool x)
        //{
            
        //    if (x.(1) = "a")
        //    {

        //    }
            

        //}
    }
}
