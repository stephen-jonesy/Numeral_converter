using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace objects
{
    public class NumberToNumerals
    {
        public static void Validation()
        {
            try
            {
                Console.Write("Enter a number between 1 & 2000: ");

                string input = Console.ReadLine();
                int number = int.Parse(input);

                if (Enumerable.Range(1,2000).Contains(number))
                {
                    string returnedNumeral = convertToNumeral(number);

                    Console.WriteLine(returnedNumeral);

                }

                else {
                    Console.Write("You must enter a number between 1 and 2000");
                    return;

                }
            }
            catch (FormatException)
            {
                Console.Write("Opps, you must enter a valid number");
                return;
            }

        }
        static string convertToNumeral(int number) {
            string result = string.Empty;
            Dictionary<int, string> RomanNumerals = new Dictionary<int, string>
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}

            };
            
            foreach (var Numeral in RomanNumerals)
            {
                result += string.Join(string.Empty, Enumerable.Repeat(Numeral.Value, number / Numeral.Key));
                // Console.WriteLine(num % pair.Key);
                int remainder = number % Numeral.Key;
                number = remainder;
            }

            return result;
        }
        
    }

}