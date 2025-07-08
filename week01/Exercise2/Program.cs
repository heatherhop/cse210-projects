using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentGrade = int.Parse(userInput);
        string letter = "";
        string sign = "";

        if (percentGrade >= 90)
        {
            letter = "A";
        }
        else if (percentGrade >= 80)
        {
            letter = "B";
        }
        else if (percentGrade >= 70)
        {
            letter = "C";
        }
        else if (percentGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        if (letter == "A" || letter == "F")
        {
            sign = "";
        }
        else
        {
            int remainder = percentGrade % 10;
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        Console.WriteLine($"You earned a {letter}{sign}.");


        if (percentGrade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Keep working hard and try again next semester.");
        }

    }
}