using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Author
    {
        private string name;
        private string surname;

        public Author (string name, string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
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
        public string Surname
        {
            get { return surname; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid name");
                }
                else
                {
                    surname = value;
                }
            }
        }
        public DateTime DateOfBirth { get; set; }
#endregion

        public override string ToString()
        {
            return String.Format("name {0}, surname {1}, yearOfBirth {2} ", Name, Surname, DateOfBirth.Date);
        }
    }
}
