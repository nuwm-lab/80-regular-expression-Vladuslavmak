using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть текст для аналізу:");
        string inputText = Console.ReadLine();

        List<string> postalCodes = FindPostalCodes(inputText);

        if (postalCodes.Count == 0)
        {
            Console.WriteLine("Поштових індексів формату 00000 не знайдено.");
        }
        else
        {
            Console.WriteLine("Знайдені поштові індекси:");
            foreach (string code in postalCodes)
            {
                Console.WriteLine($"- {code}");
            }
        }
    }

    /// <summary>
    /// Пошук поштових індексів формату 00000 у тексті.
    /// </summary>
    static List<string> FindPostalCodes(string text)
    {
        string pattern = @"\b\d{5}\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        List<string> results = new List<string>();

        foreach (Match match in matches)
        {
            results.Add(match.Value);
        }

        return results;
    }
}

