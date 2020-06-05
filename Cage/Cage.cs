using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Cage
{
    class Cage <T> where T : Animal
    {
        private List<T> list = new List<T>();

        public void AddAnimal(T animal)
        { 
            list.Add(animal);
        }

        public void RemoveAnimal(T animal)
        {
            if (list.Contains(animal))
            {
                list.Remove(animal);
            }  
        }

        public void showAnimalsInCage()
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Name);
            }
        }
    }
}
