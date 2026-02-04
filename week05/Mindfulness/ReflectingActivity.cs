public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(10);
            Console.WriteLine();
        }

        _totalDuration += _duration;

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random randPrompt = new Random();
        int index = randPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
    

    public string GetRandomQuestion()
    {
        Random randQuestion = new Random();
        int index = randQuestion.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.Write($" --- {GetRandomPrompt()} --- ");
    }
    
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}