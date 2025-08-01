using System.Data;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are your personal strengths?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public int GetCount()
    {
        return _count;
    }
    public List<string> GetPrompts()
    {
        return _prompts;
    }
    public void SetCount(int count)
    {
        _count = count;
    }
    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine("");
        GetRandomPrompt();
        Console.WriteLine("\nYou may begin in: ");
        ShowCountDown(4);

        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityDuration());

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine("\nTime's up!");
        Console.WriteLine($"You listed {responses.Count} items.");

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        Console.WriteLine($" --- {_prompts[index]} ---");
    }
    public List<string> GetListFromUser(List<string> responses)
    {
        return responses;
    }

}