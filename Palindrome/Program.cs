using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos = Console.ReadLine();
            Tester t1 = new Tester();
            //t1.Check(unos);
             
            Console.WriteLine(t1.Check(unos));
        }

        public class Tester
        {
            public bool Check(string forward)
            {
                forward = forward.Replace(" ", "");
                var backward = new string(forward.Reverse().ToArray());
                return backward.Equals(forward);
            }
        }


    }
}
