public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

// public class Blind
// {
//     public double _width;
//     public double _height;
//     public string _color;

//     public double GetArea()
//     {
//         return _width * _height;
//     }
// }