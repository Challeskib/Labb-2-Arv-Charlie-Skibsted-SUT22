using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    class Animal
    {
        public string Name = "Default Name";
        public string Colour = "Defaualt Colour";
        public string Sex = "Defaualt";
        public int Age = 0;
        public int Weight = 0;

        public void PrintBasePropertys()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Colour = {Colour}");
            Console.WriteLine($"Sex = {Sex}");
            Console.WriteLine($"Age = {Age}");
            Console.WriteLine($"Weight = {Weight}");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} sleeps..... zzzzzzzz.... zzzzzzz");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eats, mmmmpppphhhrggggg hgrhrhrh");
            Console.WriteLine($"{Name}s new weight is: {Weight+1} kilos");

        }

        

    }
}
