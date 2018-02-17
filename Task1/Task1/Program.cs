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
            Triangle triangle = stream.ReadTriangleFromFile("input.txt");
            stream.WriteToFile($"Square = {triangle.Square} { Environment.NewLine}Perimeter = { triangle.Perimeter}");
        }
    }
}
