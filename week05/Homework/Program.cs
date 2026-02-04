using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Minnie Mouse", "Fractions");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Mickey Mouse", "Division", "12", "1-20");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Donald Duck", "History", "Revolutionary War");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}