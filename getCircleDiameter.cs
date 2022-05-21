using System;

namespace O9_TP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your cirlce range : ");
            int round = Convert.ToInt32(Console.ReadLine());
            Circle circle = new Circle(round);
            Console.WriteLine("Circle Radius: {0} ", circle.getRadius());
            Console.WriteLine("Circle Diameter: {0} ", circle.getDiameter());
            Console.WriteLine("Circle Circumference: {0} ", circle.getCircumference());
            Console.WriteLine("Circle Area: {0} ", circle.getArea());
            Console.ReadLine();
        }        
    }

    class Circle {
        private double radius;
        public Circle(double radius) { this.radius = radius; }
        public Circle() { radius = 0.0; }
        public void setRadius(double radius) { this.radius = radius; }
        public double getRadius() { return radius; }
        public double getArea() { return Math.PI * radius * radius; } // Area
        public double getDiameter() { return radius * 2; } // Diameter
        public double getCircumference() { return 2 * Math.PI * radius; } // Circumference 
    }
}
