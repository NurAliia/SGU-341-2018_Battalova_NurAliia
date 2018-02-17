using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class RWStream
    {
        public Triangle ReadTriangleFromFile(string str)
        {
            //создаем файловый поток                    
            try
            {
                FileStream input = new FileStream(str, FileMode.Open);
                using (var file = new StreamReader(input))
                {
                    Triangle triangle = null;
                    string[] mas = (file.ReadLine()).Split(' ');
                    Point a;
                    Point b;
                    Point c;
                    if (Point.TryParse(mas[0], mas[1], out a) &&
                        Point.TryParse(mas[2], mas[3], out b) &&
                        Point.TryParse(mas[4], mas[5], out c))
                    {
                        triangle = new Triangle(a, b, c);
                        return triangle;
                    }

                    WriteToFile("Invalid input data");

                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception " + e.Message);

            }
            catch (IOException e)
            {
                Console.WriteLine("Exception " + e.Message);
            }
            return null;
        }
        public void WriteToFile(string str)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Output.txt");
                sw.WriteLine(str);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }
        }
    }
}
