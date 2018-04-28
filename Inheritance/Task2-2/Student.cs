using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Student : Man
    {
        private int yearOfEntry;
        private int yearOfStudy;
        private int groupNumber;
        public Student(string name, int age, int weight, int height,
         int yearOfEntry, int yearOfStudy, int groupNumber) : base(name, age, weight, height)
        {
            YearOfEntry = yearOfEntry;
            YearOfStudy = yearOfStudy;
            GroupNumber = groupNumber;
        }
        #region Properties
        public int YearOfEntry
        {
            get { return yearOfEntry; }
            set
            {
                if (value > 0)
                {
                    yearOfEntry = value;
                }
                else
                {
                    throw new Exception("Invalid year of entry");
                }
            }
        }
        public int YearOfStudy
        {
            get { return yearOfStudy; }
            set
            {
                if (value > 0)
                {
                    yearOfStudy = value;
                }
                else
                {
                    throw new Exception("Invalid year of study");
                }
            }
        }
        public int GroupNumber
        {
            get { return groupNumber; }
            set
            {
                if (value > 0)
                {
                    groupNumber = value;
                }
                else
                {
                    throw new Exception("Invalid group number");
                }
            }
        }
        #endregion
     
        public override string ToString()
        {
            return String.Format("Name {0}, age {1}, weight {2}, height {3}, yearOfEntry {4}," +
                " yearOfStudy {5}, groupNumber {6}", Name, Age, Weight, Height, YearOfEntry, YearOfStudy, GroupNumber); ;
        }
    }
}
