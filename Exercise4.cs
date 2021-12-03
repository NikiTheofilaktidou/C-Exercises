using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a circle! The center of the circle will be the point(0,0). Enter radius");
            double radInput= Convert.ToDouble(Console.ReadLine());
            Circle c = new Circle(radInput);
            Console.WriteLine("Alright, enter the coordinates of a point, let's check if it's in the circle");
            Console.WriteLine("Enter the x coordinate");
            double xInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate");
            double yInput = Convert.ToDouble(Console.ReadLine());
            Point p = new Point(xInput, yInput);
            bool InOrOut = c.IsPointInCircle(p);
        }
    }
    class Circle
    {
        const double pi = 3.14;
        public double Radius { get; set; } = 1.0;

        public Point centerPoint = new Point(0,0);

        public string FillColor { get; set; }
        public string BorderColor { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void SetRadius(double value)
        {
            Radius = value;
        }
        public void SetColor(string colorFill, string colorBorder)
        {
            FillColor = colorFill;
            BorderColor = colorBorder;
        }

        public double GetArea()
        {
            return pi * Radius * Radius;
        }

        public bool IsPointInCircle(Point p)
        {
            double a = Math.Pow(p.x - 0, 2);
            double b = Math.Pow(p.y - 0, 2);
            double c = Math.Pow(Radius, 2);
            
            if(a + b <= Radius){
                Console.WriteLine("The point is inside or on the circle.");
                return true;
            }
            Console.WriteLine("The point is outside the circle.");
            return false;
        }
    }
    class Color
    {
        public string R { get; set; } = "red";
        public string G { get; set; } = "green";
        public string B { get; set; } = "blue";
    }
    
    class Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
