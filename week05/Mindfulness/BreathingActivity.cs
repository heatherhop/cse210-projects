public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.Write("\nBreathe out...");
            ShowCountDown(4);
            Thread.Sleep(1000);
            Console.WriteLine("");
        }
        DisplayEndingMessage();

    }
}