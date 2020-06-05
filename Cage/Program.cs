using System;
using System.Collections.Generic;

namespace Cage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cage<Animal> cage = new Cage<Animal>();
            Monkey monkey = new Monkey("Klaus");
            cage.AddAnimal(monkey);
            Tiger tiger = new Tiger("Mickey");
            cage.AddAnimal(tiger);
            cage.RemoveAnimal(tiger);
            cage.showAnimalsInCage();
        }
    }
}
