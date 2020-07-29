using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Crypto_Wallet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login or Register?");
            string answer3 = Console.ReadLine();
            if (answer3 == "Login")
            {
                string username, password, username1, password1 = string.Empty;

                Console.Write("Enter your username: ");
                username = Console.ReadLine();
                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                using (StreamReader sr = new StreamReader(File.Open("D:\\C# codes\\Login register\\registration.txt", FileMode.Open)))
                {
                    username1 = sr.ReadLine();
                    password1 = sr.ReadLine();
                    sr.Close();
                }
                if (username == username1 && password == password1)
                {
                    Console.WriteLine("Login Successful");
                    HotelOptions();

                }
                else
                {
                    Console.WriteLine("Wrong username or password. Please try again by restarting the program.");
                    Console.ReadLine();
                }
            }

            else if (answer3 == "Register")
            {
                string username, password = string.Empty;

                Console.Write("Enter a username: ");
                username = Console.ReadLine();
                Console.Write("Enter a password: ");
                password = Console.ReadLine();

                using (StreamWriter sw = new StreamWriter(File.Create("D:\\C# codes\\Login register\\registration.txt")))
                {
                    sw.WriteLine(username);
                    sw.WriteLine(password);
                    sw.Close();
                }
                Console.WriteLine("Thank you for your registration");
                Console.WriteLine("Now, please login to use our services");

                string username1, password1, username2, password2 = string.Empty;

                Console.Write("Enter your username: ");
                username = Console.ReadLine();
                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                using (StreamReader sr = new StreamReader(File.Open("D:\\C# codes\\Login register\\registration.txt", FileMode.Open)))
                {
                    username1 = sr.ReadLine();
                    password1 = sr.ReadLine();
                    sr.Close();
                }
                if (username == username1 && password == password1)
                {
                    Console.WriteLine("Login Successful");
                    HotelOptions();
                }
                else
                {
                    Console.WriteLine("Wrong username or password. Please try again by restarting the program.");
                }
            }
        }

        static void HotelOptions()
        {
            int standartRoom = 20;
            int luxuryRoom = 35;
            int apartment = 60;
            Console.WriteLine("Rooms avaible: standart room, luxury room, apartment");
            Console.Write("Room: ");
            string answer1 = Console.ReadLine();
            Console.Write("Days: ");
            int days = int.Parse(Console.ReadLine());
            if (answer1 == "standart room")
            {
                int total = standartRoom * days;
                Console.WriteLine($"Total: {total}");
            }
            else if (answer1 == "luxury room")
            {
                int total = luxuryRoom * days;
                Console.WriteLine($"Total: {total}");
            }
            else if (answer1 == "apartment")
            {
                int total = apartment * days;
                Console.WriteLine($"Total: {total}");
                Console.ReadLine();
            }
        }
    }
}