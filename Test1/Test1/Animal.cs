using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    abstract class Animal
    {
        protected bool isMammal;
        protected bool isCarnivorous;

        public Animal(bool isMammal, bool isCarnivorous)
        {
            this.isMammal = isMammal;
            this.isCarnivorous = isCarnivorous;
        }

        public bool getIsMammal()
        {
            return this.isMammal;
        }

        public bool getIsCarnivorous()
        {
            return this.isCarnivorous;
        }

        abstract public string getGreeting();

        public void printAnimal(string name)
        {
            Console.WriteLine("A {0} says '{1}', is{2} carnivorous, and is{3} a mammal.",
            name,
            this.getGreeting(),
            this.getIsCarnivorous() ? "" : " not",
            this.getIsMammal() ? "" : " not");
        }
    }

    class Dog : Animal
    {
        public Dog():base(true,true)
        {
            string v = "";
            Console.WriteLine($"sfd{1}");
        }
        public override string getGreeting()
        {
            throw new NotImplementedException();
        }
    }
}
