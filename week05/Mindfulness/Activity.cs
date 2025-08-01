using System.ComponentModel;
using System.Runtime.InteropServices;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetActivityName()
    {
        return _name;
    }
    public string GetActivityDescription()
    {
        return _description;
    }
    public int GetActivityDuration()
    {
        return _duration;
    }
    public void SetActivityName(string name)
    {
        _name = name;
    }
    public void SetActivityDescription(string description)
    {
        _description = description;
    }
    public void SetActivityDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.Write($"How long, in seconds, would you like your {_name} to last? ");
        string durationInputString = Console.ReadLine();
        int durationInputInt = int.Parse(durationInputString);
        SetActivityDuration(durationInputInt);
        Console.Clear();
        Console.WriteLine("\nGet ready...");
        ShowSpinner(4);
        Console.Clear();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well Done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(4);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i % animationStrings.Count];

            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        // for (int i = 5; i > 0; i--)
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);

        // }
    }
}