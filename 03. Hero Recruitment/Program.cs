using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> herosAndSpells = new Dictionary<string, List<string>>();

        string input = "";
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];
            string heroName = tokens[1];
            if (command == "Enroll")
            {
                if (!herosAndSpells.ContainsKey(heroName))
                {
                    herosAndSpells.Add(heroName, new List<string>());
                }
                else
                {
                    Console.WriteLine($"{heroName} is already enrolled.");
                }
            }
            else if (command == "Learn")
            {
                string spell = tokens[2];
                if (herosAndSpells.ContainsKey(heroName))
                {
                    if (!herosAndSpells[heroName].Contains(spell))
                    {
                        herosAndSpells[heroName].Add(spell);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has already learnt {spell}.");
                    }
                }
                else
                {
                    Console.WriteLine($"{heroName} doesn't exist.");
                }
            }
            else if (command == "Unlearn")
            {
                string spell = tokens[2];
                if (herosAndSpells.ContainsKey(heroName))
                {
                    if (herosAndSpells[heroName].Contains(spell))
                    {
                        herosAndSpells[heroName].Remove(spell);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't know {spell}.");
                    }
                }
                else
                {
                    Console.WriteLine($"{heroName} doesn't exist.");
                }
            }
        }
        Console.WriteLine("Heroes:");
        foreach (KeyValuePair<string, List<string>> kvp in herosAndSpells)
        {
            Console.WriteLine($"== {kvp.Key}:{string.Join(", ", kvp.Value)}");
        }
    }
}
