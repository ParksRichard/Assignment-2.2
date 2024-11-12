using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_2._2
{
    /* 
         Write a base class: ‘Shape’ and add properties like id, name and color and method like ‘calculate area’ .
         Create a class called "circle", inherit the base class and add properties like radius. Add an override to calculate area logic for circle.
         Create a class called "square" inherit base class shape and add change the calculate area logic. Add property like side of square.
         Take the input from user to select circle or square and display the calculated area. No hard coded values!
    */

    //base parent class
    public abstract class Shape
    {
        //properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public abstract double Calculate(); //double input?

        //double area = 0;
        //return area;
     
    }
    //child circle class
    public class Circle : Shape
    {
        public double Radius { get; set; }

        //double area = 0;
        //area = Math.PI * Radius * Radius;
        //return area;

        //return Math.PI * Radius * Radius;

        Circle(int id, string name, string color, double radius)
        {
            Id = id;
            Name = name;
            Color = color;
            Radius = radius;
        }

        public override double Calculate()
        {
            return Math.PI * Radius * Radius;
        }
    }
    //child square class
    public class Square : Shape
    {
        public double Side { get; set; }

        //double area = 0;
        //area = side * side
        //return area;

        Square(int id, string name, string color, double side)
        {
            Id = id;
            Name = name;
            Color = color;
            Side = side;
        }
        public override double Calculate()
        {
            return Side * Side;
        }
    }

    //maths class
    class Calculating
    {
        static void Main()
        {
            Console.WriteLine("Please select which shape to calculate.");
            Console.WriteLine("");
            Console.WriteLine("Circle.");
            Console.WriteLine("Square.");
            Console.WriteLine("");
            string choice = new(Console.ReadLine());

            Shape shape = null; //failing to connect the dots here somewhere

            if (choice == "Circle")
            {
                
                Console.Write("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());
                //shape = new Circle(radius); //failing to connect the dots here somewhere
            }
            else if (choice == "Square")
            {
                
                Console.Write("Enter the side length of the square: ");
                double side = double.Parse(Console.ReadLine());
                //shape = new Square(side); //failing to connect the dots here somewhere
            }
            else
            {
                Console.WriteLine("That's not a shape!");
                return;
            }

            
            Console.WriteLine($"The area of the selected shape is: {shape.Calculate()}"); //failing to connect the dots here somewhere


            //the brackets are struggles
            ///Had top re-write bottom portion due to bracket shenanigans
        }
    }
}