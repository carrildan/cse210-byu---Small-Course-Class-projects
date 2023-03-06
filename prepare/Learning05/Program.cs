using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Rectangle rectangle = new Rectangle("blue", 4, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("green", 6);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();
        

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}