public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 * 0.00062;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / base.Duration()) * 60;
    }

    public override double GetPace()
    {
        return base.Duration() / GetDistance();
    }
}
