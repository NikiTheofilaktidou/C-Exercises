// W3resources Practice
//1.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your name!");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello: {name}");
        }
    }
}
--------
//2.
  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give first number");
            string input1 = Console.ReadLine();
            int number1 = Int32.Parse(input1);
            Console.WriteLine("Give second number");
            string input2 = Console.ReadLine();
            int number2 = Int32.Parse(input2);
            Console.WriteLine($"Their sum is: {number1 + number2}");
        }
    }
}
--------
//5.
static void Main(string[] args)
        {
            //5 askisi
            Console.WriteLine("Give first number");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            Console.WriteLine("Give second number");
            string input2 = Console.ReadLine();
            int number2 = Int32.Parse(input2);
            Console.WriteLine($"First Number: {number2} \nSecond Number: {number1}");

        }
--------
//7.        
static void Main(string[] args)
        {
            Console.WriteLine("Give first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give second number");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Their sum is: {number1 + number2}");
            Console.WriteLine($"Their sub is: {number1 - number2}");
            Console.WriteLine($"Their mult is: {number1 * number2}");
            Console.WriteLine($"Their div is: {number1 / number2}");

        }
//8.        
static void Main(string[] args)
        {
            Console.WriteLine("Give a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] multTable = new int[11];
            
            for (int i = 0; i < multTable.Length; i++)
            {
                multTable[i] = a * i;
                Console.WriteLine(multTable[i]);
            }
        }
 //9 
 //for integers
 Console.WriteLine("Give 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Give 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Give 3rd number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Give 4th number");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Their average of {0}, {1}, {2} and {3} is {4}.", a, b, c, d, (a + b + c + d) / (double)4);
            
 //for doubles
 static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("Give 1st number");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Give 2nd number");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Give 3rd number");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Give 4th number");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Their average of {0}, {1}, {2} and {3} is {4}.", a, b, c, d, (a + b + c + d) /4);
        }
          
