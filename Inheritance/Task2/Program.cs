using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {           
            Author author = new Author("Alex", "Pushkin", new DateTime(1799, 5, 26));        
            Console.WriteLine(author);
            Book b = new Book("Eugene Onegin", 150, "Drofa Plus", new DateTime(2010, 6, 21), new DateTime(1831, 10, 5), author);
            Console.WriteLine(b);
        }
    }
}
