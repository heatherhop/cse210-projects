using System.Reflection;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
    public List<string> GetPrompt()
    {
        return _prompts;
    }
    public List<string> GetQuestion()
    {
        return _questions;
    }
    public void SetPrompt(List<string> prompts)
    {
        _prompts = prompts;
    }
    public void SetQuestion(List<string> questions)
    {
        _questions = questions;
    }
    public void Run()
    {
        return;
    }
    public string GetRandomPrompt(string prompt)
    {
        return prompt;
    }
    public string GetRandomQuestion(string question)
    {
        return question;
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {

    }
}