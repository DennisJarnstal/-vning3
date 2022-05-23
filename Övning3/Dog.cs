using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Dog : Animal
    {
        private string breed;
        internal override string DoSound()
        {
            return "Voff";
        }
        public Dog(string name, double weight, int age, bool herbivore, string habitat, string color, string breed) : base(name, weight, age, herbivore, habitat, color)
        {
            Breed = breed;
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        internal override string Stats()
        {
            return base.Stats() + $"\nBreed: {breed}";
        }
        public void Run()
        {
            Console.WriteLine("Hundar gillar verkligen att springa");
        }
    }
}
