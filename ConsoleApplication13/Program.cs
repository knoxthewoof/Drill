using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInt
{
    public abstract class Customer
    {
        int ID;
        public void print() //abstract is private by deafult
        {
            Console.WriteLine("Abstract Class: ");//abstract can have fields
        }
    }
    public interface ICustomer 
    {
        void print(); //Interface is public by default, interface cannot have fields
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
