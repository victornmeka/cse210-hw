using System;

class Program
{
    static List<Goal> Goals = new List<Goal>();


    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the 'Goal Tracker' program!");
        int total = 0;


        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {total} points.");

            // Menu
            Console.WriteLine(" ");

            List<string> Menu = new List<string>()
            {
                "1. Set New Goal",
                "2. List Goals",
                "3. Save Goals",
                "4. Load Goals",
                "5. Record Event",
                "6. Quit."

            };

            Console.WriteLine("Please select an Option from the Menu:");

            foreach (string option in Menu)
            {
                Console.WriteLine(option);
            }

            // Ascertain user's Choice
            Console.WriteLine(" ");
            Console.Write("Select a choice from the menu: ");
            string UserChoice = Console.ReadLine();
            //Ensure user's choice is valid
            while (UserChoice != "1" && UserChoice != "2" && UserChoice != "3" && UserChoice != "4" && UserChoice != "5" && UserChoice != "6")
            {
                Console.WriteLine("Invalid response.  Please choose a number between 1 and 6.");
                UserChoice = Console.ReadLine();
            }

            switch (UserChoice)
            {
                case "1":

                    List<string> GoalTypesOptions = new List<string>()
                {
                    "1. Simple Goal",
                    "2. Eternal Goal",
                    "3. Checklist Goal"
                };

                    Console.WriteLine("The types of goals are:");
                    foreach (string Option in GoalTypesOptions)
                    {
                        Console.WriteLine(Option);
                    }


                    // Asccertain user choice of goal type
                    Console.Write("Which type of goal will you like to create? ");
                    string UserChoiceGT = Console.ReadLine();

                    //Declare variables
                    string Name = "";
                    string Description = "";
                    int Points = 0;
                    int CompletionPeriod = 0;


                    if (UserChoiceGT == "1")
                    {

                        SimpleGoal SimpleGoal = new SimpleGoal(Name, Description, Points, false);
                        Name = SimpleGoal.GetName();
                        Description = SimpleGoal.GetDescription();
                        Points = SimpleGoal.GetPoints();
                        Goals.Add(SimpleGoal);

                    }

                    else if (UserChoiceGT == "2")
                    {
                        EternalGoal EternalGoal = new EternalGoal(Name, Description, Points);
                        Name = EternalGoal.GetName();
                        Description = EternalGoal.GetDescription();
                        Points = EternalGoal.GetPoints();
                        Goals.Add(EternalGoal);
                    }

                    else if (UserChoiceGT == "3")
                    {
                        int Executed = 0;
                        int bonus = 0;
                        ChecklistGoal ChecklistGoal = new ChecklistGoal(Name, Description, Points, false, Executed, CompletionPeriod, bonus);
                        Name = ChecklistGoal.GetName();
                        Description = ChecklistGoal.GetDescription();
                        Points = ChecklistGoal.GetPoints();
                        CompletionPeriod = ChecklistGoal.GetCompletionPeriod();
                        bonus = Points * CompletionPeriod;
                        ChecklistGoal._CompletionPeriod = CompletionPeriod;
                        ChecklistGoal._bonus = bonus;



                        Goals.Add(ChecklistGoal);
                    }
                    break;

                case "2":




                    Console.WriteLine("The goals are: ");
                    int counter = 1;
                    foreach (Goal item in Goals)
                    {
                        Console.Write($"{counter++}."); item.ListGoal();
                    }

                    break;


                case "3":

                    Console.Write("What is the filename for the goal file? ");
                    String GoalFile = Console.ReadLine();

                    using (StreamWriter NewFile = new StreamWriter(GoalFile))
                    {

                        NewFile.WriteLine(total);

                        foreach (Goal item in Goals)
                        {
                            string data = item.Status();
                            NewFile.WriteLine(data);
                        }
                    }
                    break;

                case "4":

                    Console.Write("What is the filename for the goal file? ");
                    string LoadFile = Console.ReadLine();

                    string[] lines = System.IO.File.ReadAllLines(LoadFile);

                    total = Int32.Parse(lines[0]);

                    foreach (string data in lines)
                    {

                        string[] part = data.Split("|");

                        if (data != lines[0])
                        {

                            if (part[0] == "Simple Goal")
                            {
                                SimpleGoal SimpleGoal = new SimpleGoal(data);
                                Goals.Add(SimpleGoal);
                            }

                            else if (part[0] == "Eternal Goal")
                            {
                                EternalGoal EternalGoal = new EternalGoal(data);
                                Goals.Add(EternalGoal);
                            }

                            else if (part[0] == "Checklist Goal")
                            {
                                ChecklistGoal ChecklistGoal = new ChecklistGoal(data);
                                Goals.Add(ChecklistGoal);
                            }
                        }
                    }
                    break;

                case "5":

                    Console.WriteLine("The goals are: ");
                    int counter0 = 1;

                    Console.WriteLine();
                    foreach (Goal item in Goals)

                    {
                        Console.Write($"{counter0++}."); item.ListGoal();
                    }
                    Console.WriteLine();
                    Console.Write("Which goal did you accomplish? ");
                    int choice = Int32.Parse(Console.ReadLine());

                    Goal Selected = Goals[choice - 1];
                    total += Selected._value;
                    Selected.RecordEvent();
                    Console.WriteLine($"Congratulations you have earned {Selected._value} points");

                    break;

                case "6":

                    Console.WriteLine("Ended!");
                    return;

            }
        }
    }
}