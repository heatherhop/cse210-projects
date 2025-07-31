using System.ComponentModel;

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
        return;
    }
    public void DisplayEndingMessage()
    {
        return;
    }
    public void ShowSpinner(int seconds)
    {
        return;
    }
    public void ShowCountDown(int seconds)
    {
        return;
    }
}