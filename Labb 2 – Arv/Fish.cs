using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    class Fish : Animal
    {
        //  km/h
        public int SwimSpeed = 0;

        public Fish(string name, string colour, string sex, int age, int weight, int swimSpeed) : base(name, colour, sex, age, weight)
        {
            SwimSpeed = swimSpeed;
        }

        public Fish() //default constructor
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Blububububububblbubublub.......blub");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} swims in the speed of {SwimSpeed} km/h");
        }


    }
}
