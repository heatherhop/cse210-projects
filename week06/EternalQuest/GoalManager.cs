using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _totalGoalsAccomplished;
    public GoalManager(int score)
    {
        _goals = new List<Goal>();
        _score = score;
        _totalGoalsAccomplished = 0;
    }
    public void Start()
    {
        string menuOption = "";

        while (menuOption != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice from the menu: "); ;
            menuOption = Console.ReadLine();

            if (menuOption == "1")
            {
                CreateGoal();
            }
            else if (menuOption == "2")
            {
                ListGoalDetails();
            }
            else if (menuOption == "3")
            {
                SaveGoals();
            }
            else if (menuOption == "4")
            {
                LoadGoals();
            }
            else if (menuOption == "5")
            {
                RecordEvent();
            }
            else if (menuOption != "6")
            {
                Console.WriteLine("\nInvalid option. Please try again.");
            }
        }
        Console.WriteLine("See you next time. Keep progressing!");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    // public void ListGoalNames()
    // {
    //     Console.WriteLine("The goals are:");
    //     for (int i = 0; i < _goals.Count; i++)
    //     {
    //         Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
    //     }
    // }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have not created any goals yet.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string userGoalChoice = Console.ReadLine();

        if (userGoalChoice == "1")
        {
            Console.Write("\nWhat is the name of your goal? ");
            string simpleName = Console.ReadLine();
            Console.Write("What is the short description of it? ");
            string simpleDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string simplePoints = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);
            _goals.Add(simpleGoal);
            Console.WriteLine("You have added your goal to the list.");

        }
        if (userGoalChoice == "2")
        {
            Console.Write("\nWhat is the name of your goal? ");
            string eternalName = Console.ReadLine();
            Console.Write("What is the short description of it? ");
            string eternalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string eternalPoints = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
            _goals.Add(eternalGoal);
            Console.WriteLine("You have added your goal to the list.");
        }
        if (userGoalChoice == "3")
        {
            Console.Write("\nWhat is the name of your goal? ");
            string ChecklistName = Console.ReadLine();
            Console.Write("What is the short description of it? ");
            string checklistDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string checklistPoints = Console.ReadLine();
            Console.Write("How many times would you like to achieve this goal? ");
            string checklistTarget = Console.ReadLine();
            Console.Write($"What is the amount of bonus points to be awarded if this goal is complete {checklistTarget} times? ");
            string checklistBonus = Console.ReadLine();
            ChecklistGoal checklistGoal = new ChecklistGoal(ChecklistName, checklistDescription, checklistPoints, checklistTarget, checklistBonus);
            _goals.Add(checklistGoal);
            Console.WriteLine("You have added your goal to the list.");
        }
    }
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Goal goalToRecord = _goals[goalIndex - 1];
            if (!goalToRecord.IsComplete())
            {
                goalToRecord.RecordEvent();
                string pointsString = goalToRecord.GetPoints();
                int pointsEarned = int.Parse(pointsString);
                _score += pointsEarned;
                _totalGoalsAccomplished++;

                if (_totalGoalsAccomplished == 3)
                {
                    _score += 50;
                    Console.WriteLine("You earned 50 bonus points for completing 3 goals!");
                    _totalGoalsAccomplished = 0;
                }
            }
            else
            {
                Console.WriteLine("That goal is already complete.");
            }
        }
        else
        {
            Console.WriteLine("\nInvalid goal number. Please try again.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);

                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("You have successfully saved your goals to the file called myGoals.txt.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn error occurred while saving the file: {ex.Message}");
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        _goals.Clear();
        _score = 0;

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string goalType = parts[0];
            string[] details = parts[1].Split(',');

            if (goalType == "SimpleGoal")
            {
                string name = details[0];
                string description = details[1];
                string points = details[2];
                bool IsComplete = bool.Parse(details[3]);

                SimpleGoal newGoal = new SimpleGoal(name, description, points);
                if (IsComplete)
                {
                    newGoal.RecordEvent();
                }
                _goals.Add(newGoal);
            }
            if (goalType == "EternalGoal")
            {
                string name = details[0];
                string description = details[1];
                string points = details[2];

                EternalGoal newGoal = new EternalGoal(name, description, points);
                _goals.Add(newGoal);
            }
            if (goalType == "ChecklistGoal")
            {
                string name = details[0];
                string description = details[1];
                string points = details[2];
                string targetAmount = details[3];
                string bonus = details[4];
                string amountCompleted = details[5];

                ChecklistGoal newGoal = new ChecklistGoal(name, description, points, targetAmount, bonus);
                for (int j = 0; j < int.Parse(amountCompleted); j++)
                {
                    newGoal.RecordEvent();
                }
                _goals.Add(newGoal);
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}