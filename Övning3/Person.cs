using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Person
    {
        private int age;
        private double height;
        private double weight;
        private string fName;
        private string lName;


        public int Age
        {
            get { return age; }
            set 
            {
                if (value > 0)
                {
                    age = value;
                }
                else 
                {
                  
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Längd kan inte vara mindre än 1");
                }
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Vikt kan inte vara mindre än 1");
                }
            }
        }
        public string FName
        {

            get { return fName; }
            set 
            {
                if (value.Length is > 1 and < 11)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("Förnamn måste vara mellan 2 och 10 bokstäver långt.");
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length is > 2 and < 16)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("Efternamn måste vara mellan 3 och 15 bokstäver långt.");
                }
            }
        }
    }
}
