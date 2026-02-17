using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>
        {
            new Running("17 Feb 2026", 30, 2),
            new Cycling("16 Feb 2026", 45, 15),
            new Swimming("15 Feb 2026", 20, 20)
        };

        foreach (Activity a in activity)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}