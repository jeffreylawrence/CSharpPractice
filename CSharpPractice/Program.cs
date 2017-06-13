using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner0 = new Person();

            Pet pet0 = new Pet();
            /* my first program in C# */
            Console.WriteLine("Welcome to the Pet Simulator");
            Console.WriteLine("Please select your pet name.");
            pet0.Name = Console.ReadLine();
            pet0.Owner = owner0;

            Food catFood = new Food("Iams Wet Cat Food", "Meat", 50);
            Food dogFood = new Food("PC Senior Dog Food", "Meat", 50);


            Pet pickles = new Pet("Pickles", owner0, 14, 50);
            pickles.eatFood(catFood, 1);

            Dog ginger = new Dog("Ginger", owner0, 15,30);
            ginger.eatFood(dogFood,3);

            ginger.bark();
            ginger.bark(3);

            

            Console.ReadLine();
        }
    }
}
