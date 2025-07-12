using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class RandomPromptGenerator
{
    public List<string> _prompts = new List<string>
            {
                "What happened today?",
                "What was the best thing that happened today?",
                "What was the worst thing that happened today?",
                "What was the most interesting thing I saw or heard today?",
                "What was the most challenging thing I faced today?",
                "What am I grateful for today?",
                "What did I learn today?",
                "What was the most fun thing I did today?",
                "What was the most surprising thing that happened today?",
                "What did I do today that I am proud of?",
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

    private Random _random = new Random();
    public string GetRandomPrompt()
    {
        if (_prompts == null || _prompts.Count == 0)
        {
            return "No prompts available.";
        }

        int index = _random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}
