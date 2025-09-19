using System.Drawing;

namespace Module_1_Review;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, select your shape!\nEnter circle, triangle, rectangle, or square.");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "circle")
        {
            Console.WriteLine("Please, tell me the radius of the circle in inches?");
            double radius = double.Parse(Console.ReadLine());
            CircleAreaMethod(radius);
        }
        else if (userInput.ToLower() == "triangle")
        {
            Console.WriteLine("Please, tell me the length of the triangle's base in inches?");
            double baseLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, tell me the height of the triangle in inches?");
            double height = double.Parse(Console.ReadLine());
            TriangleAreaMethod(baseLength, height);
        }
        else if (userInput.ToLower() == "rectangle")
        {
            Console.WriteLine("Please, tell me the length of the rectangle in inches?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, tell me the width of the rectangle in inches?");
            double width = double.Parse(Console.ReadLine());
            RectangleAreaMethod(length, width);
        }
        else if (userInput.ToLower() == "square")
        {
            Console.WriteLine("Please, tell me the length of a side of the square in inches?");
            double side = double.Parse(Console.ReadLine());
            SquareAreaMethod(side);
        }
    }
    
   private static void CircleAreaMethod(double radius)
    {
        double circleArea = Math.PI * radius * radius;
        Console.WriteLine($"The area of the circle is {circleArea}");
    }
   
    private static void TriangleAreaMethod(double baseLength, double height)
    {
        double triangleArea = (baseLength * height)/2;
        Console.WriteLine($"The area of the triangle is {triangleArea}");
    }
    
    private static void RectangleAreaMethod(double length, double width)
    {
        double rectangleArea = length * width;
        Console.WriteLine($"The area of the rectangle is {rectangleArea}");
    }
    
    private static void SquareAreaMethod(double side)
    {
        double squareArea = side * side;
        Console.WriteLine($"The area of the square is {squareArea}");
    }
}