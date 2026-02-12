using System.IO;
using System.Numerics;
using System.Xml.Serialization;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string input;
        
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                CreateGoal();
            }

            else if (input == "2")
            {
                ListGoalDetails();
            }

            else if (input == "3")
            {
                SaveGoals();
            }

            else if (input == "4")
            {
                LoadGoals();
            }

            else if (input == "5")
            {
                RecordEvent();
            }

        } while (input != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();
 
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (choice == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }

        else if (choice == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }

        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }

        _goals.Add(newGoal);
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        Goal goal = _goals[choice - 1];

        goal.RecordEvent();
        _score += goal.GetPoints();

        Console.WriteLine($"Congratulations! You earned {goal.GetPoints()} points!");
        Console.WriteLine($"You now have {_score} points.");
    }


    public void SaveGoals()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal g = new SimpleGoal(name, description, points);
                g.SetComplete(isComplete);
                _goals.Add(g);
            }

            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal g = new EternalGoal(name, description, points);
                _goals.Add(g);
            }

            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal g = new ChecklistGoal(name, description, points, target, bonus);
                g.SetAmountCompleted(amountCompleted);
                _goals.Add(g);
            }
        }
    }
}