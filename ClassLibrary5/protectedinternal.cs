using System;
using AssemblyThree;

namespace ClassLibrary4
{
    public class AssemblyThreeClass2 : AssemblyThreeClass1
    {
        public void Print()
        {
            AssemblyThreeClass1 A1 = new AssemblyThreeClass1();
            base.ID = 101;//protected internal allows access from a different assembly if it is derived from the containing class

            AssemblyThreeClass2 A2 = new AssemblyThreeClass2();
            A2.ID = 102;
        }
    }
}
