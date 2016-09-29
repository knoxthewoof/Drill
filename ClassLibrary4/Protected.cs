using System;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        internal int ID = 1001;
    }
    public class AssemblyOneClass2
    {
        static public void Main()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            Console.WriteLine(A1.ID);

            //In doing this it makes it only accessible to classes within this program.
        }
    }
}