using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Regex regex = new Regex(@"^\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#$");

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Match match = regex.Match(input);
            if (match.Success)
            {
                string boss = match.Groups["boss"].Value;
                string title = match.Groups["title"].Value;
                Console.WriteLine(boss + ", The " + title);
                Console.WriteLine($">> Strength: {boss.Length}");
                Console.WriteLine($">> Armour: {title.Length}");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }
    }
}

