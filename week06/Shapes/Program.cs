using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("blue", 15);
        Rectangle rectangle = new Rectangle("pink", 14, 12);
        Circle circle = new Circle("green", 7);

        DisplayShapeAreaColor(square);
        DisplayShapeAreaColor(rectangle);
        DisplayShapeAreaColor(circle);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }

    }
    public static void DisplayShapeAreaColor(Shape shape)
    {
        string color = shape.GetColor();
        double area = shape.GetArea();
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Area: {area}");
    }
}