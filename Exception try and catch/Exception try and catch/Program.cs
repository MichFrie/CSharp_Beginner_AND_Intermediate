using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_try_and_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number = ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second number = ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            /*catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            dividedbyzero + format exception
            */
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            /*
             finally
             {
                 always execute the code no matter what
             }
             */
            Console.ReadLine();
        }
    }
}
