public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return (_distance / base.Duration()) * 60;
    }

    public override double GetPace()
    {
        return base.Duration() / _distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

}
