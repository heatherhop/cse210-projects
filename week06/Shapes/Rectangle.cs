using System.ComponentModel.DataAnnotations;

public class Rectangle : Shape
{
    public double _length;
    public double _width;
    public double GetLength()
    {
        return _length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}