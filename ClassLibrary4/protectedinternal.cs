using System;

namespace AssemblyThree
{
    public class AssemblyThreeClass1
    {
        protected internal int ID = 1001;
    }
    public class AssemblyThreeClass2
    {
        static public void Main()
        {
            AssemblyThreeClass1 A1 = new AssemblyThreeClass1();
            Console.WriteLine(A1.ID);

            //In doing this it makes it only accessible to classes within this program.
        }
    }
}