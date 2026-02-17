public class Swimming : Activity
{
    private int _numberLaps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _numberLaps = laps;
    }

    public override double Distance()
    {
        return _numberLaps * 50 / 1000 * 0.62;
    }

    public override double Speed()
    {
        return Distance() / _minutes * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }
}
