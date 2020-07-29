using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class ItalianChief : Chief
    {
        public void MakePizza()
        {
            Console.WriteLine("The italian chief makes pizza.");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The italian chief makes pasta.");
        }
    }
}
