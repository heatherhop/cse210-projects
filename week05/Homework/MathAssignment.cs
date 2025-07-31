public class MathAssignment : Assignments
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetTextBookSection()
    {
        return _textbookSection;
    }
    public void SetTextBookSection(string textBookSection)
    {
        _textbookSection = textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Textbook Section: {_textbookSection}\nProblems: {_problems}";
    }
}