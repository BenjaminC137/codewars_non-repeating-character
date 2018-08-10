using System;
using System.Linq;

namespace codewars_non_repeating_character
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = Kata.FirstNonRepeatingLetter("salasek");
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
            string answer = "error";

            var firstLetter = s.GroupBy(x => x)
                               .Select(y => new { y.Key, Count = y.Count()}
                               //.where (x => x.Count < 2)
            
            );

                               //.OrderBy(y => y);
                               //OrderByDescending(s.Key).LastOrDefault(s)
            foreach (var result in firstLetter)
            {
                if (result.Count < 2)
                {

                    answer = result.Key.ToString();
                    break;
                }
                Console.WriteLine("{0} = {1}", result.Key, result.Count);
            }
            //Console.WriteLine(firstLetter.Where(x => x.Count == 1));
            //return s.Substring(0, 1);
            return answer;
            
        }
    }
}





//Write a function named firstNonRepeatingLetter† that takes a string input, and returns the first character that is not repeated anywhere in the string.
//For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.
//As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter.For example, the input 'sTreSS' should return 'T'.
//If a string contains all repeating characters, it should return the empty string ("").
//† Note: the function is called firstNonRepeatingLetter for historical reasons, but your function should handle any Unicode character.