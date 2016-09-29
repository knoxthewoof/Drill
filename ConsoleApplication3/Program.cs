using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueRef
{
    class VRTest
    {
        static void Main(string[] args)
        {
            int a = 10;

            Console.WriteLine("Value of 'a' before 'PassVal' function is called :" + a, a);
            passVal(a);
            Console.WriteLine("Value of 'a' after 'PassVal' function is called :" + a, a);

            Console.WriteLine("Value of 'a' before 'PassRef' function is called :" + a,  a);
            passRef(ref a);
            Console.WriteLine("Value of 'a' after 'PassRef' function is called : " + a, a);
        } 
        public static void passVal(int number)//the value type is the value that is getting passed into the function
        {
            number = 0;
        }

        public static void passRef(ref int number) //reference type refers to the location the class is stored in memory and is a pointer to that location.
        {
            number = 0;
        }
    }
}
