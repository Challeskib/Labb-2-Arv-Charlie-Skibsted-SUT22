using System;

namespace Labb_2___Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat nisse = new Cat("Nisse", "Black", "Male", 4, 7, 20);

            nisse.MakeSound();
            nisse.Hiss();
            nisse.Eat();

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            Bird birdie = new Bird("Anna", "White", "Female", 8, 4, 40);

            birdie.Sleep();
            birdie.MakeSound();
            Console.Write(birdie.GetWingSpan());

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            Fish nemo = new Fish();

            nemo.PrintBasePropertys();

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            Shark sharky = new Shark("Hans", "White", "Male", 33, 40, 40, 400);

            sharky.MakeSound();
            sharky.Bite();

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            Dolphin flipper = new Dolphin("Flipper", "Grey", "Female", 15, 90, 55, 100);

            flipper.MakeSound();
            flipper.Jump();


        }
    }
}
