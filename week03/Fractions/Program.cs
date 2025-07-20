using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        f.SetTop(4);
        Console.WriteLine(f.GetTop());
        f.SetBottom(5);
        Console.WriteLine(f.GetBottom());
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        Fraction f1 = new Fraction(5);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(6, 2);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(1, 7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}