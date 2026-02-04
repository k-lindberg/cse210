public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
        _prompts = new List<string>
        {
            " --- Who are people that you appreciate? --- ",
            " --- What are personal strengths of yours? --- ",
            " --- Who are people that you have helped this week? --- ",
            " --- When have you felt the Holy Ghost this month? --- ",
            " --- Who are some of your personal heroes? --- ",
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt.");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userResponses = GetListFromUser();

        _count = userResponses.Count;

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        _totalDuration += _duration;

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randPrompt = new Random();
        int index = randPrompt.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }
    
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            responses.Add(input);
        }
        return responses;
    }
}