using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_methods
{
    internal class Program
    {
        // Abstract base class
        abstract class Shape
        {
            public abstract double GetArea();
        }

        // Derived class Circle
        class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public override double GetArea()
            {
                return Math.PI * radius * radius;
            }
        }

        // Derived class Rectangle
        class Rectangle : Shape
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public override double GetArea()
            {
                return width * height;
            }
        }

        
        
            static void Main(string[] args)
            {
                Console.WriteLine("Abstract Classes and Methods Example");

                // Create instances of Circle and Rectangle
                Circle circle = new Circle(7);
                Rectangle rectangle = new Rectangle(4, 5);

                // Display areas
                Console.WriteLine($"Area of Circle with radius 7: {circle.GetArea():F2}");
                Console.WriteLine($"Area of Rectangle with width 4 and height 5: {rectangle.GetArea():F2}");
            }
        }
    }
