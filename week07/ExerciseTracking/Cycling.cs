public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return Speed() * (_minutes / 60.0);
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }
}