using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This utilizes the this. keyword, overloading and overriding.

namespace DrillPartOne
{
    class Character
    {
        public string name { get; set; }
        public string race { get; set; }
        public string spec { get; set; }
        public int level { get; set; }

        public Character()
        {
            this.name = "No Name Chosen"; ///Utilizing the this. keyword
            this.race = "No Race Selected";
            this.spec = "No Spec Selected";
            this.level = 0;
            numOfCharacters++;
        }

        public Character(string name, string race, string spec, int level)
        {
            this.name = name;
            this.race = race;
            this.spec = spec;
            this.level = level;
            numOfCharacters++;
        }
        static int numOfCharacters = 0;

        public static int getnumOfCharacters()
        {
            return numOfCharacters;
        }

        public string toString()
        {
            return String.Format("{0} is a {1} that is trained as a {2} and is a level of {3}",
                name, race, spec, level);
        }

        public int getExp(int exp1 = 1, int exp2 = 1)
        {
            return exp1 + exp2;
        }
        public double getExp(double exp1 = 1, double exp2 = 1)
        {
            return exp1 + exp2;
        }
        static void Main(string[] args)
        {
            Character Char1 = new Character("Toby", "human", "Warrior", 110);

            Console.WriteLine("{0} is a {1}", Char1.name, Char1.race);

            Console.WriteLine("You currently have " + Character.getnumOfCharacters() + " Character(s)");

            Console.WriteLine(Char1.toString());

            //This Shows Overload by using the double or the int method for the getExp method
            Console.WriteLine(Char1.getExp(1000.00, 1345.00) + " Remaining Experience until the next level");
            Console.WriteLine(Char1.getExp(1000, 783) + " Remaining Experience until the next level");

            Character Char2 = new Character
            {
                name = "PewPew",
                race = "Gnome",
                spec = "Mage",
                level = 108 
            };

            Console.WriteLine(Char2.toString());

            hunter aimedShot = new hunter();

            aimedShot = new hunter("Aimedshot", "Gnome", "Hunter", 109, "Arrows");

            Console.WriteLine(aimedShot.toString());


        }
        

    }
    class hunter : Character /// derived class, utilizes inheritance form the base and expands on it
    {
        public string ammoType { get; set; }

        public hunter() : base()
        {
            this.ammoType = "Ammo";
        }
        public hunter(string name, string race, string spec, int level, string ammoType): 
            base(name, race, spec, level)
        {
            this.ammoType = ammoType;
        }

        new public string toString()
        {
            return String.Format("{0} is a {1} that is trained as a {2} and is a level of {3} and shoots {4}",
                name, race, spec, level, ammoType);
        }

    }
}