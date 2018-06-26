using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlaton
{
    // Make a class sealed otherwise user can create multiple instance
   public sealed class Singlaton
    {
        private static int counter = 0;

        private static Singlaton _instance = null;
        public static Singlaton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singlaton();
                return _instance;
            }

        }

      private  Singlaton()
        {
            counter++;
            Console.WriteLine("counter "+counter);
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        //
        //public class child:Singlaton
        //{

        //}
    }
}
