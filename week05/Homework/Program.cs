using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assignment1 = new Assignments("Heather", "Linear Equations");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment math1 = new MathAssignment("Heather", "Linear Equations", "7.7", "1-25, odd");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        WritingAssignment writing1 = new WritingAssignment("Heather", "History of Math", "The History of Math in Ancient Eastern Asia");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());

    }
}