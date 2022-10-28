using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    class Dolphin : Fish
    {
        public int JumpHeight = 0;



        public Dolphin(string name, string colour, string sex, int age, int weight, int swimSpeed, int jumpHeight) : base(name, colour, sex, age, weight, swimSpeed)
        {
            JumpHeight = jumpHeight;
        }

        public Dolphin() //default constructor
        {

        }



        public void Jump()
        {
            Console.WriteLine($"{Name} jumps {JumpHeight} centimeters");
        }

    }
}
