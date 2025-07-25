using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text;
// Exceeding Requirements: I added a scripture library with a method that chooses scriptures randomly for the program.
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Scripture scripture = scriptureLibrary.GetRandomScripture();
        // Reference reference1 = new Reference("Helaman", 5, 12);
        // Scripture scripture1 = new Scripture(reference1, "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("");
        string answer = "";

        while (answer != "quit" && scripture.IsCompletelyHidden() != true)
        {
            Console.WriteLine("Press enter to hide words or type 'quit' to exit: ");
            answer = Console.ReadLine();

            if (answer.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
        }
        Console.WriteLine("Thank you for memorizing this scripture!");
    }
}
