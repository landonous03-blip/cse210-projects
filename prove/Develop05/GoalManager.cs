using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> lb_goals;
    private int lb_score;

    public GoalManager()
    {
        lb_goals = new List<Goal>();
        lb_score = 0;
    }

    public void Start()
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {lb_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        double points = double.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            SimpleGoal newGoal = new SimpleGoal(name, description, points);
            lb_goals.Add(newGoal);
        }
        else if (goalType == "2")
        {
            EternalGoal newGoal = new EternalGoal(name, description, points);
            lb_goals.Add(newGoal);
        }

        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            double bonus = double.Parse(Console.ReadLine());

            ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
            lb_goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type. Returning to main menu.");
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < lb_goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {lb_goals[i].GetDetailsString()}");
        }
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? (e.g., goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(lb_score);
            foreach (Goal goal in lb_goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals successfully saved!");
    }

    private void LoadGoals()
    {
        Console.Write("What is the filenamefor the goal file? (e.g., goals.txt): ");
        string filename = Console.ReadLine();

        if (System.IO.File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            lb_score = int.Parse(lines[0]);
            lb_goals.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');
                string goalType = parts[0];
                string[] data = parts[1].Split(',');

                if (goalType == "SimpleGoal")
                {
                    string name = data[0];
                    string description = data[1];
                    double points = double.Parse(data[2]);
                    bool isComplete = bool.Parse(data[3]);
                    SimpleGoal sg = new SimpleGoal(name, description, points, isComplete);
                    lb_goals.Add(sg);
                }
                else if (goalType == "EternalGoal")
                {
                    string name = data[0];
                    string description = data[1];
                    double points = double.Parse(data[2]);
                    EternalGoal eg = new EternalGoal(name, description, points);
                    lb_goals.Add(eg);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = data[0];
                    string description = data[1];
                    double points = double.Parse(data[2]);
                    double bonus = double.Parse(data[3]);
                    int target = int.Parse(data[4]);
                    int amountCompleted = int.Parse(data[5]);

                    ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                    lb_goals.Add(cg);
                }
            }
            Console.WriteLine("Goals successfully loaded!");
        }
        else
        {
            Console.WriteLine("File not found. Please check the name and try again.");
        }
    }

    private void RecordEvent()
    {
        // Safety check: Make sure they actually have goals to complete
        if (lb_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals yet! Go make one first!");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < lb_goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {lb_goals[i].GetDetailsString()}");
        }

        Console.Write("Which goal did you accomplish? ");

        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < lb_goals.Count)
        {
            double pointsEarned = lb_goals[goalIndex].RecordEvent();

            lb_score += (int)pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {lb_score} points.");

            int newLevel = lb_score / 1000;
            int oldLevel = (lb_score - (int)pointsEarned) / 1000;

            if (newLevel > oldLevel)
            {
                Console.WriteLine();
                Console.WriteLine("==================================================");
                Console.WriteLine($"= LEVEL UP! You achieved Rank {newLevel} status! =");
                Console.WriteLine("==================================================");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}