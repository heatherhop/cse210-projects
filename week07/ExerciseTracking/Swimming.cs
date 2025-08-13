public class Swimming : Activity
{
    private float _numberLaps;
    public Swimming(string date, int duration, float laps) : base(date, duration)
    {
        _numberLaps = laps;
    }
    public override float GetDistance()
    {
        return _numberLaps * 50 / 1000 * 0.62f;
    }
    public override float GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }
    public override float GetPace()
    {
        return GetDuration() / GetDistance();
    }
    public override string GetActivitySummary()
    {
        string activitySummary = base.GetActivitySummary();
        return $"Swimming {activitySummary}";
    }
}