using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDayBootCamp
{
    // Parent is Animal class
    class Animal
    {
        public void AnimalSound()
        {
            // i do not know which animal it is...
            Console.WriteLine("From Animal (parent) Class");
        }
        public void Sleep()
        {
            Console.WriteLine("Zzzzzzzzz");
        }
    }

    class Dog : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Woooo");
        }
    }
    class Cat : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Meeeee");
        }
        public void Sleep()
        {
            Console.WriteLine("From Cat class: zzz");
        }
    }

    class Tester2
    {
        /*public static void Main(string [] args)
        {
            Cat cat1 = new Cat(); // Creates Cat object
            cat1.AnimalSound();
            cat1.Sleep();
            Dog dog1 = new Dog();   
            dog1.Sleep();
            dog1.AnimalSound();
        }*/

    }
}
