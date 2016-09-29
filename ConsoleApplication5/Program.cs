using System;

class Dog
{
    private string name = "Poochie J Barks-A-Lot";
    private double age = 8.2;

    public string GetName()
    {
        return name;
    }

    public double Age
    {
        get { return age; }
    }
}

class PrivateTest
{
    static void Main()
    {
        Dog e = new Dog();

        // The data members are inaccessible (private), so
        //Console.WriteLine("The dog's name is {0} and they are {1} years old", e.name(), e.age);
        //will throw an error

        //Can be used accesses using a e.GetName() and e.Age method
        string n = e.GetName();
        double a = e.Age;
        Console.WriteLine("The dog's name is {0} and they are {1} years old", e.GetName(), e.Age);
    }
    
}