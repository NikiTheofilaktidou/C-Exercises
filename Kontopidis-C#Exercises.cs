//Exercises of beginner level in C#
//For convenience and to avoid repeatition, I will be skipping the typing of the libraries, the namespace and the class.

//The user gives 4 inputs and we must print them with the space of a tab from each other.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskhseisKontopodis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give an integer, a real number, a character and a string");
            int a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            string d = Console.ReadLine();

            Console.WriteLine($"{a}\t{b}\t{c}\t{d}");
        }
    }
}
 
 
//Calculation of 2 integers the user gives 
static void Main(string[] args)
        {
            Console.WriteLine("Give first integer");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give second integer");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",a,b,(a+b));
        }


//The user gives 3 grades and gets their average printed on the console.
static void Main(string[] args)
        {
            Console.WriteLine("Give first score");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Give second score");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Give third score");
            float c = float.Parse(Console.ReadLine());
            
            float d = (float)Math.Floor((a + b + c) / 3);

            Console.WriteLine("Your average score is {0}", d);
        }


//The user inserts an integer and we print the square power of it to the console.
static void Main(string[] args)
        {
            Console.WriteLine("Give an integer");
            int a = Int32.Parse(Console.ReadLine());
            int b = (int)Math.Pow(a, 2);
            Console.WriteLine("The square integer of the one you gave is : {0}",b);
        }
        
        
//The user will give a 4-digit integer and the console will print the digits vertically
static void Main(string[] args)
        {
            Console.WriteLine("Give a 4-digit integer");
            string input = Console.ReadLine();

            foreach (char inp in input)
            {
                Console.WriteLine(inp);
            }
        }
        
//The user inserts the coordinates of two points a(x1,y1) and b(x2,y2) and we calculate the distance betweent them.
static void Main(string[] args)
        {
            Console.WriteLine("Give the horizontal coordinate of the first point x1");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Give the vertical coordinate of the first point y1");
            float y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Give the horizontal coordinate of the first point x2");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Give the vertical coordinate of the first point y2");
            float y2 = float.Parse(Console.ReadLine());

            float sq1 = (float)Math.Pow(x1 - x2, 2);
            float sq2 = (float)Math.Pow(y1 - y2, 2);
            float hypo = (float)Math.Sqrt(sq1 + sq2);
            
            Console.WriteLine($"The length of the line that connects the two points (x1,y1) and (x2,y2) is:{hypo}");
        }
        
        
//The user gives a number and we print its absolute value
static void Main(string[] args)
        {
            Console.WriteLine("Give a number");
            double a = double.Parse(Console.ReadLine());
            double abs = (double)Math.Abs(a);
            Console.WriteLine("The number you provided has an absolute of {0}",abs);
        }
        
//The user gives an integer and we print if it's even or odd
 static void Main(string[] args)
        {
            Console.WriteLine("Give an integer");

            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((c % 2 == 0) ? "It's an even number!" : "It's an odd number!");
        }

//
