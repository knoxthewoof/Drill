using System;
using AssemblyOne;

namespace ClassLibrary5
{
    public class AssemblyTwoClass1
    {
        public void Print()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1(); 
            //A1.ID = 101; //this is inaccessible because its internal within AssemblyoneClass1
        }
    }
}
