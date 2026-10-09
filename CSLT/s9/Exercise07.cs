using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.s9
{
    internal class Exercise07
    {
        // 1. Input and print a string
        static void PrintString(string str)
        {
            Console.WriteLine("Input string: " + str);
        }

        // 2. Find length without using library function
        static int FindLength(string str)
        {
            int length = 0;
            foreach (char c in str)
                length++;
            return length;
        }

        // 3. Separate individual characters
        static void SeparateCharacters(string str)
        {
            Console.WriteLine("Characters:");
            foreach (char c in str)
                Console.WriteLine(c);
        }

        // 4. Print characters in reverse order
        static void PrintReverse(string str)
        {
            Console.WriteLine("Reverse characters:");
            for (int i = str.Length - 1; i >= 0; i--)
                Console.WriteLine(str[i]);
        }

        // 5. Count words in a string
        static int CountWords(string str)
        {
            int count = 0;
            bool inWord = false;
            foreach (char c in str)
            {
                if (char.IsWhiteSpace(c))
                    inWord = false;
                else if (!inWord)
                {
                    inWord = true;
                    count++;
                }
            }
            return count;
        }

        // 6. Compare two strings without library functions
        static bool CompareStrings(string str1, string str2)
        {
            if (FindLength(str1) != FindLength(str2))
                return false;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    return false;
            }
            return true;
        }

        // 7. Count alphabets, digits, special characters
        static void CountCharacters(string str)
        {
            int alphabets = 0, digits = 0, specials = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c)) alphabets++;
                else if (char.IsDigit(c)) digits++;
                else specials++;
            }
            Console.WriteLine($"Alphabets: {alphabets}, Digits: {digits}, Specials: {specials}");
        }

        // 8. Count vowels and consonants
        static void CountVowelsConsonants(string str)
        {
            int vowels = 0, consonants = 0;
            string vowelSet = "aeiouAEIOU";
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    if (vowelSet.Contains(c)) vowels++;
                    else consonants++;
                }
            }
            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }

        // 9. Check if substring is present
        static bool ContainsSubstring(string str, string sub)
        {
            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                int j;
                for (j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j]) break;
                }
                if (j == sub.Length) return true;
            }
            return false;
        }

        // 10. Search position of substring
        static int SubstringPosition(string str, string sub)
        {
            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                int j;
                for (j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j]) break;
                }
                if (j == sub.Length) return i;
            }
            return -1;
        }

        // 11. Check if character is alphabet and case
        static void CheckAlphabetCase(char c)
        {
            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                    Console.WriteLine($"{c} is an uppercase alphabet.");
                else
                    Console.WriteLine($"{c} is a lowercase alphabet.");
            }
            else
                Console.WriteLine($"{c} is not an alphabet.");
        }

        // 12. Count occurrences of substring
        static int CountSubstringOccurrences(string str, string sub)
        {
            int count = 0;
            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                int j;
                for (j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j]) break;
                }
                if (j == sub.Length) count++;
            }
            return count;
        }

        // 13. Insert substring before first occurrence of another string
        static string InsertSubstring(string str, string target, string insert)
        {
            int pos = SubstringPosition(str, target);
            if (pos == -1) return str;
            return str.Substring(0, pos) + insert + str.Substring(pos);
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            PrintString(input);
            Console.WriteLine("Length: " + FindLength(input));
            SeparateCharacters(input);
            PrintReverse(input);
            Console.WriteLine("Word count: " + CountWords(input));
            CountCharacters(input);
            CountVowelsConsonants(input);

            Console.Write("Enter another string to compare: ");
            string input2 = Console.ReadLine();
            Console.WriteLine("Strings equal? " + CompareStrings(input, input2));

            Console.Write("Enter substring to search: ");
            string sub = Console.ReadLine();
            Console.WriteLine("Contains substring? " + ContainsSubstring(input, sub));
            Console.WriteLine("Substring position: " + SubstringPosition(input, sub));
            Console.WriteLine("Occurrences: " + CountSubstringOccurrences(input, sub));

            Console.Write("Enter substring to insert before target: ");
            string insert = Console.ReadLine();
            Console.Write("Enter target string: ");
            string target = Console.ReadLine();
            Console.WriteLine("After insertion: " + InsertSubstring(input, target, insert));

            Console.Write("Enter a character to check: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            CheckAlphabetCase(ch);
        }
    }
}
