using System;


interface ICustomer
{
    void Print(); 
}

class Customer : ICustomer
{
    public void Print()
    {
        Console.WriteLine("Interface Print Method");
    }
}

    public class Program
{
    static void Main(string[] args)
    {
        Customer C1 = new Customer();
        C1.Print();
    }
 }

