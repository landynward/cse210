using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public DateTime Date => _date;
    public int Minutes => _minutes;

    protected Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Minutes} min)";
    }
}
