using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersWar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game!");

            Console.Write("Gamer 1 name: ");
            string gamer1 = Console.ReadLine();

            Console.Write("Gamer 2 name: ");
            string gamer2 = Console.ReadLine();

            int[] InBattle1 = new int[3];
            int[] InBattle2 = new int[3];
            int Total1 = 0 , Total2 = 0;

            int gamer1Card = 0;
            int gamer2Card = 0;

            int gamer1Points = 0;
            int gamer2Points = 0;

            int turns = 0;
            bool EndOfGame = false;

            try
            {
                do
                {
                    Console.WriteLine();
                    Console.Write("{0} turn:", gamer1);
                    gamer1Card = int.Parse(Console.ReadLine());

                    if ( gamer1Card > 10 || gamer1Card < 2)
                    {
                        turns = 3;
                        EndOfGame = true;
                    }

                    Console.Write("{0} turn:", gamer2);
                    gamer2Card = int.Parse(Console.ReadLine());

                    if (gamer2Card > 10 || gamer2Card < 2 )
                    {
                        turns = 3;
                        EndOfGame = true;
                    }

                    if (gamer1Card > gamer2Card)
                    {
                        gamer1Points = gamer1Card - gamer2Card;
                        turns += 1;
                    }
                    else if (gamer2Card > gamer1Card)
                    {
                        gamer2Points = gamer2Card - gamer1Card;
                        turns += 1;
                    }

                    if (gamer1Card == gamer2Card)
                    {
                        Console.WriteLine("Number war");
                        Console.WriteLine("{0} turn in battle:", gamer1);
                        InBattle1[0] = int.Parse(Console.ReadLine());
                        InBattle1[1] = int.Parse(Console.ReadLine());
                        InBattle1[2] = int.Parse(Console.ReadLine());
                        for (int i = 0; i < InBattle1.Length; i++)
                        {
                            Total1 += InBattle1[i];
                        }

                        Console.WriteLine("{0} turn in battle:", gamer2);
                        InBattle2[0] = int.Parse(Console.ReadLine());
                        InBattle2[1] = int.Parse(Console.ReadLine());
                        InBattle2[2] = int.Parse(Console.ReadLine());
                        for (int i = 0; i < InBattle2.Length; i++)
                        {
                            Total2 += InBattle2[i];
                        }

                        if (Total1 > Total2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("{0} wins", gamer1);
                        }
                        else if (Total2 > Total1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("{0} wins", gamer2);
                        }
                        gamer1Points = gamer2Points;
                        turns = 3;
                    }

                } while (turns < 3);

                if (!EndOfGame)
                {
                    if (gamer1Points > gamer2Points)
                    {
                        Console.WriteLine();
                        Console.WriteLine("{0} wins", gamer1);
                    }
                    else if (gamer2Points > gamer1Points)
                    {
                        Console.WriteLine();
                        Console.WriteLine("{0} wins", gamer2);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Too big or small card!!!");
                    Console.ReadKey();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Letters are not numbers of cards!!!");
                Console.ReadKey();
            }
        }
    }
}
