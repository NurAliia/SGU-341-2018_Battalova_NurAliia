using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            RWStream stream = new RWStream();
            try
            {
                Triangle triangle = stream.ReadTriangleFromFile("input.txt");
                stream.WriteToFile($"Perimeter = {triangle.Perimeter} { Environment.NewLine}Square = {triangle.Square}");                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
