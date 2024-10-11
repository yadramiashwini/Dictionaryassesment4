
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            // Sample input
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            CountWords(input);
        }

        static void CountWords(string input)
        {
            // Split the input string by colon
            string[] words = input.Split(':');

            // Check for invalid length (customize as needed)
            if (words.Length == 0 || (words.Length == 1 && string.IsNullOrWhiteSpace(words[0])))
            {
                Console.WriteLine("Invalid length");
                return;
            }

            // Create a dictionary to count occurrences
            Dictionary<string, int> countDict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in words)
            {
                string normalizedWord = word.Trim().ToUpper(); // Normalize to upper case

                if (!string.IsNullOrEmpty(normalizedWord))
                {
                    if (countDict.ContainsKey(normalizedWord))
                    {
                        countDict[normalizedWord]++;
                    }
                    else
                    {
                        countDict[normalizedWord] = 1;
                    }
                }
            }

            // Sort and print the output
            foreach (var entry in countDict)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }
    }
