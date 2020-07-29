using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Chief
    {
        public void MakeSalad()
        {
            Console.WriteLine("The chif makes salad.");
        }
        public void MakeSoup()
        {
            Console.WriteLine("The chif makes soup.");
        }
        public void MakeDesserts()
        {
            Console.WriteLine("The chif makes desserts.");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chief makes BBQ ribs");
        }
    }
}
