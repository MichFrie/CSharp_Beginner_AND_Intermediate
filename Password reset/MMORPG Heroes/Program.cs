using System;
using System.Collections.Generic;
using System.Linq;

namespace MMORPG_Heroes
{
    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }

        public Hero(int hp, int mp)
        {
            HP = hp;
            MP = mp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> party = new Dictionary<string, Hero>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (int.Parse(input[1]) <= 100 && int.Parse(input[2]) <= 200)
                {
                    party.Add(input[0], new Hero(int.Parse(input[1]), int.Parse(input[2])));
                }
            }

            string input1;

            while ((input1 = Console.ReadLine()) != "End")
            {
                string[] c = input1.Split(" - ");

                if (c[0] == "CastSpell")
                {
                    if (party[c[1]].MP < int.Parse(c[2]))
                    {
                        Console.WriteLine($"{c[1]} does not have enough MP to cast {c[3]}!");
                    }
                    else
                    {
                        party[c[1]].MP -= int.Parse(c[2]);
                        Console.WriteLine($"{c[1]} has successfully cast {c[3]} and now has {party[c[1]].MP} MP!");
                    }
                }
                else if (c[0] == "TakeDamage")
                {
                    if (party[c[1]].HP <= int.Parse(c[2]))
                    {
                        Console.WriteLine($"{c[1]} has been killed by {c[3]}!");
                        party.Remove(c[1]);
                    }
                    else
                    {
                        party[c[1]].HP -= int.Parse(c[2]);
                        Console.WriteLine($"{c[1]} was hit for {c[2]} HP by {c[3]} and now has {party[c[1]].HP} HP left!");
                    }
                }
                else if (c[0] == "Recharge")
                {
                    if (party[c[1]].MP + int.Parse(c[2]) > 200)
                    {
                        int recharge = 200 - party[c[1]].MP;
                        party[c[1]].MP += recharge;
                        Console.WriteLine($"{c[1]} recharged for {recharge} MP!");
                    }
                    else
                    {
                        int recharge = int.Parse(c[2]);
                        party[c[1]].MP += recharge;
                        Console.WriteLine($"{c[1]} recharged for {recharge} MP!");
                    }
                }
                else
                {
                    if (party[c[1]].HP + int.Parse(c[2]) > 100)
                    {
                        int heal = 100 - party[c[1]].HP;
                        party[c[1]].HP += heal;
                        Console.WriteLine($"{c[1]} healed for {heal} HP!");
                    }
                    else
                    {
                        int heal = int.Parse(c[2]);
                        party[c[1]].HP += heal;
                        Console.WriteLine($"{c[1]} healed for {heal} HP!");
                    }
                }
            }
            party = party.OrderByDescending(h => h.Value.HP).ThenBy(h => h.Key).ToDictionary(k => k.Key, v => v.Value);
            foreach (var hero in party)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }
    }
}
