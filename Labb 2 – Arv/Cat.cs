using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    class Cat : Animal
    {
        // Centimeters
        public int TailLength = 0;

        public Cat(string name, string colour, string sex, int age, int weight, int taillenght) : base(name, colour, sex, age, weight)
        {
            TailLength = taillenght;
        }

        public Cat() : base() //default constructor
        {

        }


        public void Hiss()
        {
            Console.WriteLine($"{Name} Hisses!!!!!! ssssssszsszzszszs!!!! ");

        }

        public void MakeSound()
        {
            Console.WriteLine("Mjao Mjao Mjao");
        }


    }
}
