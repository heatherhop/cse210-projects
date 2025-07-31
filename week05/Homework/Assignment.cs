using System.Reflection.Metadata.Ecma335;

public class Assignments
{
    private string _studentName;
    private string _topic;
    public Assignments(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"Student Name: {_studentName}\nTopic: {_topic}";
    }

};
