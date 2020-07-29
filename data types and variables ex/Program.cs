using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int startingPokePower = pokePower;
            int targetsPoked = 0;

            while (pokePower >= distanceBetweenTargets)
            {
                if (pokePower == startingPokePower / 2 && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;

                    if (pokePower < distanceBetweenTargets)
                    {
                        break;
                    }
                }

                pokePower -= distanceBetweenTargets;
                targetsPoked++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}