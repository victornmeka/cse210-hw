public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }


    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetDistance()
    {
        return (_speed * base.Duration()) / 60;
    }
}
