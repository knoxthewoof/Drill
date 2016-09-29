using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullDemo
{
    class NullableExample
    {
        static void Main()
        {
            int? number = null;

            if (number.HasValue)
            {
                System.Console.WriteLine(" The number = " + number.Value);
            }
            else
            {
                System.Console.WriteLine("The number = Null");
            }

            // val is set to zero
            int val = number.GetValueOrDefault();

            // number.Value throws an InvalidOperationException if num.HasValue is false
            try
            {
                val = number.Value;
            }
            catch (System.InvalidOperationException g)
            {
                System.Console.WriteLine(g.Message);
            }
        }
    }
}