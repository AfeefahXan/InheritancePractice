using System;

namespace oopcsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("");

            Dog myDog = new Dog();
            myDog.soundDog();
            Console.WriteLine("I am a " + myDog.dogBreed[4] + "!");

            Console.WriteLine("");

            Cat myCat = new Cat();
            myCat.soundCat();
            Console.WriteLine("I am a " + myCat.catBreed[6] + "!");

        }
    }
}
