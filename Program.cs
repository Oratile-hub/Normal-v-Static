using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normal_v_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Static_Method_Class.greetingStatic();

            Normal_Method_class salute = new Normal_Method_class();
            salute.greeting();
            

            //freeze console
            Console.ReadLine();
        }
    }
}
