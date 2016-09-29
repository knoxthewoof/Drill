using System;
struct StructDemo
{
    private double numVal;
    public double Xval
    {
        get
        {
            return numVal;
        }
        set 
        {
            if (value < 100)
                numVal = value;

            
                    
        }
    }
    public void DisplaynumVal()
    {
        Console.WriteLine("The value in the struct is: {0}", numVal);
    }
}

class TestClass
{
    public static void Main()
    {
        StructDemo sd = new StructDemo();
        sd.Xval = 65.07;
        sd.DisplaynumVal();
    }
}