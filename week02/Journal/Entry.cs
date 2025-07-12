public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _promptText;
    public string _entryText;
    public string _entryEmotion;

    public Entry()
    {
        RandomPromptGenerator myPrompt = new RandomPromptGenerator();
        _promptText = myPrompt.GetRandomPrompt();
    }

    public Entry(string date, string prompt, string entryText, string emotion)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entryText;
        _entryEmotion = emotion;
    }



    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"You are feeling {_entryEmotion} today.");
    }  
}