using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;
        string dateString = currentDate.ToString("MMMM d, yyyy");

        Running run1 = new Running(dateString, 30, 2);
        Bicycle cycle1 = new Bicycle(dateString, 45, 6);
        Swimming swim1 = new Swimming(dateString, 25, 7);
        Running run2 = new Running(dateString, 30, 3);
        Running run3 = new Running(dateString, 30, 4.8f);

        List<Activity> activities = new List<Activity>();
        activities.Add(run1);
        activities.Add(cycle1);
        activities.Add(swim1);
        activities.Add(run2);
        activities.Add(run3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetActivitySummary());
        }
    }
}