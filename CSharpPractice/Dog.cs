using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Dog : Pet
    {

        public Dog(string name, Person owner, int age, int energyLevel)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.energyLevel = energyLevel;
            this.isAlive = true;
        }

        public void walk()
        {
            Console.WriteLine($"{this.Name} the dog is going for a walk.");
        }

        public void walk(double kilometers)
        {
            Console.WriteLine($"{this.Name} the dog is going for a {kilometers}km walk.");
        }

        public void bark()
        {
            Console.WriteLine("woof");
        }

        public void bark(int volume)
        {
            switch (volume)
            {
                case 0:
                    Console.WriteLine("...");
                    break;
                case 1:
                    this.bark();
                    break;
                case 2:
                    Console.WriteLine("Woof!");
                    break;
                case 3:
                    Console.WriteLine("WOOF!");
                    break;
                default:
                    this.bark();
                    break;
            }
            

        }
    }
}
