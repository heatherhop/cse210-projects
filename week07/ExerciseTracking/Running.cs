public class Running : Activity
{
    private float _distance;

    public float GetRunningDistance()
    {
        return _distance;
    }
    public void SetRunningDistance(float distance)
    {
        _distance = distance;
    }
    public Running(string date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return _distance / GetDuration() * 60;
    }
    public override float GetPace()
    {
        return GetDuration() / _distance;
    }
    public override string GetActivitySummary()
    {
        string activitySummary = base.GetActivitySummary();
        return $"Running {activitySummary}";
    }
}