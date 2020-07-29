using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a name of the book: ");
                string a = Convert.ToString(Console.ReadLine());
                Console.Write("Enter an author's name: ");
                string b = Convert.ToString(Console.ReadLine());
                Console.Write("Enter the number of the pages: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");
                Console.WriteLine("Your book is:");
                Book book1 = new Book(a, b, c);
                Console.WriteLine(book1.title + "\nby " + book1.author + "\nwith " + book1.pages + "pages");
            }
            
            catch(Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine(e.Message);

            }
                
            
            Console.ReadLine();
        }
    }
}
