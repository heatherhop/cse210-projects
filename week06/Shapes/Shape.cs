using System.Drawing;

public class Shape
{
    private string _color;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        color = _color;
    }
    public Shape(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return 0;
    }
}

// The instructor made this class an abstract class because it didn't make sense to 
// have a virtual funtion like I made above. I made the function this way because the 
// assignment instructions said to make an virtual function. These were his comments.
// Because it does not make sense to define a default body for this method in the
// base class, rather than make a "virtual" function here like this:
//
// public virtual double GetArea()
// {
//     return 0;
// }
//
// We can instead declare the function as an "abstract" function. That means
// that it is an empty virtual function that must be implemented or "filled in" by
// any class that inherits from Shape. Then, any class that has an abstract method
// must also be declared to be abstract.
// public abstract double GetArea();


// See the comment above about the abstract method. Because we have an abstract method,
// this class must also be declared as an abstract class.
// public abstract class Shape