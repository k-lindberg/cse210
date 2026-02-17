public abstract class Activity
{
    private string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();
    
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes})- Distance {Distance():0.0} miles, Speed {Speed():0.0} mph, Pace: {Pace():0.0} min per mile";
    }
}