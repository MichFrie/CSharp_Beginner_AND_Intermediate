using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Book book1 = new Book("Robin Hood", 315); 
            Book book2 = new Book("The Lord Of The Rings", 682);
            Book book3 = new Book("Manual", 15);

            var Search = new Dictionary<string, object>();

            Search.Add("book1" , book1.Name + " - " + book1.pages + " pages");
            Search.Add("book2" , book2.Name + " - " + book2.pages + " pages");
            Search.Add("book3" , book3.Name + " - " + book3.pages + " pages");


            Console.WriteLine("Write \nbook1 to open" + book1.Name + "\nbook2 to open " + book2.Name + "\nbook3 to open " + book3.Name);
            string Open = Console.ReadLine();

            if (Search.TryGetValue(Open, out object description))
            {
                Console.WriteLine(description);
            }
            Console.ReadKey(); 
        }
    }
}
