using System;
// Exceeding requirements: I added a counter to the main program so that when the user quits the program it will display the number of activities that they did. It will display the word activity or the word activities, depending on the number of activities.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        string activityChoice = "";
        int activityCount = 0;

        while (activityChoice != "4")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("\nSelect an option from the menu: ");
            activityChoice = Console.ReadLine();

            if (activityChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                activityCount += 1;
            }
            else if (activityChoice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                activityCount += 1;
            }
            else if (activityChoice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                activityCount += 1;
            }
            else if (activityChoice == "4")
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nThank you for being more mindful. Goodbye.");
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please try again.");
                Thread.Sleep(2000);
            }
        }
        if (activityCount == 1)
        {
            Console.WriteLine($"You have completed {activityCount} activity.");
        }
        else
        {
            Console.WriteLine($"You have completed {activityCount} activities.");
        }

    }
}