using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    public delegate void SampDele();
    class Program
    { 
        public static void Main()
        {
            SampDele del1, del2, del3, del4;
            del1 = new SampDele(SampOne);
            del2 = new SampDele(SampTwo);
            del3 = new SampDele(SampThree);

            del4 = del1 + del2 + del3;
            del4();
        }
        public static void SampOne()
        {
            Console.WriteLine("Sample Method One Used");
        }
        public static void SampTwo()
        {
            Console.WriteLine("Sample Method Two Used");
        }
        public static void SampThree()
        {
            Console.WriteLine("Sample Method Three Used");
        }
        
    }
    
}
