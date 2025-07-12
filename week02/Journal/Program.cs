using System;
using System.IO.Pipes;
// exceeding expectations 
// I added a prompted for the user to add the emotion that they felt at the time of entry and displayed it with the entry. I also removed the "~~" delimiters from the txt file after loading.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your online journal.");

        Journal myJournal = new Journal();
        string choice = "";
        string journalFile = "entries.txt";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry anEntry = new Entry();
                Console.WriteLine($"Prompt: {anEntry._promptText}");
                Console.WriteLine("Please write your entry: ");
                anEntry._entryText = Console.ReadLine();
                Console.WriteLine("What is the emotion that you feel? ");
                anEntry._entryEmotion = Console.ReadLine();
                myJournal.AddEntry(anEntry);
                Console.WriteLine("Your new entry was saved.");
                anEntry.Display();

            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                myJournal.LoadFromFile(journalFile);
            }
            else if (choice == "4")
            {
                myJournal.SaveToFile(journalFile);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for your journal entry.");
            }
            else
            {
                Console.WriteLine("Sorry, that's not a valid option. Please choose 1, 2, 3, 4, or 5.");
            }
        }
    }
}