using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlaton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singlaton s = Singlaton.Instance;
            s.Print("Print the message");

            Singlaton s1 = Singlaton.Instance;
            s1.Print("Print the message again");

            Console.WriteLine("----------------------------------------");

            Singlaton.child s2 = new Singlaton.child();
            s2.Print("Print from child class");

            Console.ReadLine();
        }
    }
}
