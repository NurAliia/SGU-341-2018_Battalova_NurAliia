using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Book
    {
        private string name;
        private int numberOfPages;
        private string publishingHouse;
        private DateTime dateOfPublication;
        private DateTime dateOfWriting;
        private Author author;

        public Book(string name, int nop, string ph, DateTime dop, DateTime dow, Author author)
        {
            this.name = name;
            Author = author;
            NumberOfPages = nop;            
            PublishingHouse = ph;
            DateOfPublication = dop;
            DateOfWriting = dow;
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
        public int NumberOfPages
        {
            get { return numberOfPages; }
            set
            {
                if (value > 0)
                {
                    numberOfPages = value;
                }
                else
                {
                    throw new Exception("Invalid number of pages");
                }
            }
        }        
        public string PublishingHouse
        {
            get { return publishingHouse; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid name");
                }
                else
                {
                    publishingHouse = value;
                }
            }
        }
        public DateTime DateOfWriting
        {
            get { return dateOfWriting; }
            set
            {
                if (value > author.DateOfBirth)
                {
                    dateOfWriting = value;
                }
                else
                {
                    throw new Exception("Invalid date of writing");
                }
            }
        }
        public DateTime DateOfPublication
        {
            get { return dateOfWriting; }
            set
            {
                if (value > DateOfWriting)
                {
                    dateOfPublication = value;
                }
                else
                {
                    throw new Exception("Invalid date of publication");
                }
            }
        }
        public Author Author
        {
            get { return author; }
            set
            {
                if (value is Author)
                {
                    author = value;
                }
                else
                {
                    throw new Exception("Invalid Info author");
                }
            }
        }
        #endregion

        public override string ToString()
        {
            return String.Format("name {0},  numberOfPages {1}, publishingHouse {2}, dateOfPublication {3}, " +
                " dateOfWriting {4}, author {5}", Name, NumberOfPages, PublishingHouse, DateOfPublication.Date, DateOfWriting.Date, Author);
        }
    }
}
