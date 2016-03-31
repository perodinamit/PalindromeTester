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
            public bool Check(string input)
            {
                input = input.Replace(" ", "");
                var reversed = new string(input.Reverse().ToArray());
                return reversed.Equals(input);
            }
        }


    }
}
