using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    class Bird : Animal
    {
        //Centimeters
        public int WingLength = 0;


        public Bird(string name, string colour, string sex, int age, int weight, int winglength)
        {
            Name = name;
            Colour = colour;
            Sex = sex;
            Age = age;
            Weight = weight;
            WingLength = winglength;

        }

        public Bird() //default constructor
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("ChirpChirpChirp");
        }

        public int GetWingSpan()
        {
            Console.Write($"{Name}s Wingspan is: ");
            return WingLength + WingLength;
        }

    }
}
