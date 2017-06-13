using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
     public class Pet
    {
        protected string name;
        protected Person owner;
        protected int age;
        protected int energyLevel;
        protected int hungerLevel;
        protected bool isAlive;

        
        public Pet()
        {

        }

        public Pet(string name, Person owner, int age, int energyLevel)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.energyLevel = energyLevel;
            this.isAlive = true;
        }


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal Person Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public int EnergyLevel
        {
            get
            {
                return energyLevel;
            }

            set
            {
                energyLevel = value;
            }
        }

        public int HungerLevel
        {
            get
            {
                return hungerLevel;
            }

            set
            {
                hungerLevel = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }

            set
            {
                isAlive = value;
            }
        }

        public void eatFood(Food food, int amount)
        {
            //Check Hunger Level
            //Reduce Hunger level
            //
            Console.WriteLine($"{Name} has eaten {amount} portion(s) of {food.Name}.");
        }

        public void sleep(double hours)
        {
            //Check Energy Level (if energyLevel > 75){ cannot fall asleep}
            Console.WriteLine($"{Name} has fallen asleep for {hours} hours.");
        }





    }
}
