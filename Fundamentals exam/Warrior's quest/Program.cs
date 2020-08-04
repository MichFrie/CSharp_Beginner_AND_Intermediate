using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Warrior_s_quest
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder skill = new StringBuilder();
            skill.Append(Console.ReadLine());
            string input;

            while ((input = Console.ReadLine()) != "For Azeroth")
            {
                string[] command = input.Split();

                if (command[0] == "GladiatorStance")
                {
                    string skillNew = skill.ToString().ToUpper();

                    skill.Clear();
                    skill.Append(skillNew);

                    Console.WriteLine(skill);
                }
                else if (command[0] == "DefensiveStance")
                {
                    string skillNew = skill.ToString().ToLower();

                    skill.Clear();
                    skill.Append(skillNew);

                    Console.WriteLine(skill);
                }
                else if (command[0] == "Dispel")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < skill.Length)
                    {
                        char new1 = char.Parse(command[2]);
                        skill[index] = new1;
                        
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (command[0] == "Target" && command[1] == "Change")
                {
                    int pos = skill.ToString().IndexOf(command[2]);
                    if (pos >= 0)
                    {
                        skill.Replace(command[2], command[3]);
                       
                    }
                   
                    Console.WriteLine(skill);

                }
                else if (command[0] == "Target" && command[1] == "Remove")
                {
                    skill.Replace(command[2], "");
                    Console.WriteLine(skill);
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }

        }
    }
}
