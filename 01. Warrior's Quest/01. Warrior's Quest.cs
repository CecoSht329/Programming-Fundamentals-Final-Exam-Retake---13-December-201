using System;
using System.Text;

class Program
{
    static void Main()
    {
        string skill = Console.ReadLine();

        string input = "";
        while ((input = Console.ReadLine()) != "For Azeroth")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (input.StartsWith("GladiatorStance"))
            {
                skill = skill.Replace(skill, skill.ToUpper());
                Console.WriteLine(skill);
            }
            else if (input.StartsWith("DefensiveStance"))
            {
                skill = skill.Replace(skill, skill.ToLower());
                Console.WriteLine(skill);
            }
            else if (input.StartsWith("Dispel"))
            {
                int index = int.Parse(tokens[1]);
                char letter = char.Parse(tokens[2]);

                if (index >= 0 && index < skill.Length)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < skill.Length; i++)
                    {
                        sb.Append(skill[i]);
                        if (i == index)
                        {
                            sb[i] = letter;
                        }
                    }
                    skill = sb.ToString();
                    Console.WriteLine("Success!");
                }
                else
                {
                    Console.WriteLine("Dispel too weak.");
                }
            }
            else if (input.StartsWith("Target Change"))
            {
                string substring = tokens[2];
                string secondSubstring = tokens[3];

                skill = skill.Replace(substring, secondSubstring);
                Console.WriteLine(skill);
            }
            else if (input.StartsWith("Target Remove"))
            {
                string substring = tokens[2];
                int index = skill.IndexOf(substring);
                skill = skill.Replace(substring, "");
                Console.WriteLine(skill);
            }
            else
            {
                Console.WriteLine("Command doesn't exist!");
            }
        }
    }
}

