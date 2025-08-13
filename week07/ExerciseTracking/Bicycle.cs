public class Bicycle : Activity
{
    private float _bikeSpeed;

    public Bicycle(string date, int duration, float speed) : base(date, duration)
    {
        _bikeSpeed = speed;
    }
    public override float GetDistance()
    {
        return _bikeSpeed * (GetDuration() / 60);
    }
    public override float GetSpeed()
    {
        return _bikeSpeed;
    }
    public override float GetPace()
    {
        return 60 / _bikeSpeed;
    }
    public override string GetActivitySummary()
    {
        string activitySummary = base.GetActivitySummary();
        return $"Cycling: {activitySummary}";
    }

}