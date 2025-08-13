public abstract class Activity
{
    private string _dateOfActivity;
    private int _durationInMinutes;

    public string GetDate()
    {
        return _dateOfActivity;
    }
    public int GetDuration()
    {
        return _durationInMinutes;
    }
    public void SetDate(string date)
    {
        _dateOfActivity = date;
    }
    public void SetDuration(int duration)
    {
        _durationInMinutes = duration;
    }
    public Activity(string date, int duration)
    {
        _dateOfActivity = date;
        _durationInMinutes = duration;
    }
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public virtual string GetActivitySummary()
    {
        return $"{GetDate()} - ({GetDuration()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}