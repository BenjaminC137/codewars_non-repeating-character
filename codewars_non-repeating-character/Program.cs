using System;
using System.Linq;

namespace codewars_non_repeating_character
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = Kata.FirstNonRepeatingLetter("illinois");
            Console.WriteLine(answer);
        }
    }

    public class Kata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            //int[] cCountArray = new int[s.Length];
            //int[] c = new int[s.Length];

            //for (int i = 0; i < s.Length; i++){
            //    foreach (char character in s)
            //        {
            //        cCountArray[i]++;
            //        c[i]++;
            //        Console.WriteLine(i + " " + c[i] + " " + cCountArray[i] + " " + character);
            //        }
            //}
            //s.ToCharArray();
            var firstLetter = s.GroupBy(x => x)
                               .OrderBy(x => x.Key);
                               //OrderByDescending(s.Key).LastOrDefault(s)


            Console.WriteLine(firstLetter);
            return s.Substring(0, 1);
            
        }
    }
}





//Write a function named firstNonRepeatingLetter† that takes a string input, and returns the first character that is not repeated anywhere in the string.
//For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.
//As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter.For example, the input 'sTreSS' should return 'T'.
//If a string contains all repeating characters, it should return the empty string ("").
//† Note: the function is called firstNonRepeatingLetter for historical reasons, but your function should handle any Unicode character.