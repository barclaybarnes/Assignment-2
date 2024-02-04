using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.IO;

namespace Assignment_2
{
    class Driver
    {

        public static English englishobject = new English();
        public static bool wordContainsLetter(string word, char letter)
        {
            char[] charArray = new char[word.Length];

            charArray = word.ToCharArray();

            foreach (char c in charArray)
            {
                if (c == letter)
                {
                    return true;
                }

            }
            return false;
        }

        public static bool wordContainsString(string word, string letters)
        {
            Console.WriteLine("What word would you like to evaluate?");
            word = Console.ReadLine();
            Console.WriteLine("What letter pattern would you like to search for in this word?");
            letters = Console.ReadLine();

            if (word.Contains(letters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static void guessWordWithLetters(English english, string letters, int wordlength)
        {
            foreach(string word in english.words) 
            { 
                if (word.Length == wordlength) 
                {
                    bool lettersArePresent = true;

                    foreach (char c in word) 
                    {
                        if (!word.Contains(letters))
                        {
                            lettersArePresent = false;
                        }
                    }

                    if (lettersArePresent) 
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }

        public static void guessWordWithPattern(English english, string pattern, int length)
        {
            foreach (string word in english.words) 
            {
                if (word.Length == length)
                {
                    if (word.Contains(pattern))
                    {
                        Console.WriteLine(word);
                    }
                }
                    
            }
        }
        

      

        public static void Main(string[] args)
        { 
     
            Console.WriteLine("What is the length of the word you'd like to find");
            int wordlength = Convert.ToInt32(Console.ReadLine());

            int x = 0;
            Console.WriteLine("Do you want me to look for letters or a pattern?");
            Console.WriteLine("1) Letters");
            Console.WriteLine("2) Pattern");
            x = Convert.ToInt32(Console.ReadLine());
            switch(x)
            {
                case 1:
                    Console.WriteLine("What letters are in the word?");
                    string wordletters = Console.ReadLine();

                    guessWordWithLetters(englishobject, wordletters, wordlength);
                    break;
                case 2:
                    Console.WriteLine("What pattern is in the word?");
                    string wordpattern = Console.ReadLine();

                    guessWordWithPattern(englishobject, wordpattern, wordlength);

                    break;

            }
                      
        }






    }
}

