using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    class Shark : Fish
    {
        public int NumberOfTeeth = 0;

        public Shark(string name, string colour, string sex, int age, int weight, int swimSpeed, int numberOfTeeth) : base(name, colour, sex, age, weight, swimSpeed)
        {
            NumberOfTeeth = numberOfTeeth;
        }

        public Shark() //default constructor
        {

        }

        public void Bite()
        {
            Console.WriteLine($"{Name} bites you with {NumberOfTeeth} teeth");
        }

    }
}
