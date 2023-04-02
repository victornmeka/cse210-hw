public abstract class Activity
{
    private DateTime _date;
    private double _duration;

    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public double Duration()
    {
        return _duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_duration} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per mile";
    }
}