public class ListActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
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
        return;
    }
    public void GetRandomPrompts()
    {
        return;
    }
    public List<string> GetListFromUser(List<string> prompts)
    {
        return prompts;
    }
    
}