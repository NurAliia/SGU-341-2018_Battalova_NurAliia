using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Man
    {
        private string name;
        private int age;
        private int weight;
        private int height;
        public Man (string name, int age, int weight, int height)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
        }
        #region Properties
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid name");                    
                }
                else
                {
                    name = value;
                }
            }
        }
        
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
                    throw new Exception("Invalid age");
                }
            }
        }
        public int Weight
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
                    throw new Exception("Invalid weight");
                }
            }
        }
        public int Height
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
                    throw new Exception("Invalid height");
                }
            }
        }
#endregion
       
        private string Print()
        {
            return String.Format("Name {0}, age {1}, weight {2}, height {3} ", Name, Age, Weight, Height);
        }

        public override string ToString()
        {
            return Print();
        }
    }
}
