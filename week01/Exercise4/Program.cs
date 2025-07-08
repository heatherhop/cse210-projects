using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int count = 0;
        int sum = 0;
        int largest = -1000;
        int numberEntered;

        do
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            numberEntered = int.Parse(userInput);

            if (numberEntered != 0)
            {
                numbers.Add(numberEntered);
                count += 1;
                sum += numberEntered;

                if (numberEntered > largest)
                {
                    largest = numberEntered;
                }
            }
        } while (numberEntered != 0);

        double average = (double)sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}