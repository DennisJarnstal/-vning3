using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    abstract class Animal
    {
        private string name;
        private double weight;
        private int age;
        private bool herbivore = true;
        private string habitat;
        private string color;

        internal abstract string DoSound();


        public Animal(string name, double weight, int age, bool herbivore, string habitat, string color)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Herbivore = herbivore;
            Habitat = habitat;
            Color = color;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public bool Herbivore
        { 
        get { return herbivore;}
            set
            {
                herbivore = value;
            }

        }
        public string Habitat
        {
            get { return habitat;}
            set
            {
                habitat = value;
            }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        internal virtual string Stats()
        {
            return $"Name: {name}\nWeight: {weight}\nAge: {age}\nHerbivore: {herbivore}\nHabitat: {habitat}\nColor: {color}";
        }

    }

}
