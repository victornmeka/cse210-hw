public class ChecklistGoal : Goal
{

    private string GoalType = "Checklist Goal";

    public int _Executed;

    public int _bonus;

    public int _CompletionPeriod;
    private bool _Completed;

    public ChecklistGoal(string name, string description, int pointsPerCompletion, bool Completed, int Executed, int CompletionPeriod, int bonus)
        : base(name, description, pointsPerCompletion)
    {
        _Executed = Executed;
        _bonus = bonus;
        _Completed = Completed;
        _CompletionPeriod = CompletionPeriod;
    }

    public ChecklistGoal(string data) : base(data)
    {
        string[] part = data.Split("|");
        _Completed = bool.Parse(part[6]);

    }


    public override string GetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        return _name;
    }

    public override string GetDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        return _description;
    }

    public override int GetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        _value = Int32.Parse(Console.ReadLine());
        return _value;
    }
    public override int GetCompletionPeriod()
    {
        Console.Write("How many times does this goal need to be accomplished? ");
        int CompletionPeriod = Int32.Parse(Console.ReadLine());
        return CompletionPeriod;
    }

    public override string Status()
    {
        string stats = $"{GoalType}|{_name}|{_description}|{_value}|{_Executed}|{_CompletionPeriod}|{_Completed}";
        return stats;
    }


    public override Goal StringData(string data)
    {
        string[] part = data.Split("|");
        _name = part[1];
        _description = part[2];
        _value = Int32.Parse(part[3]);
        _Executed = Int32.Parse(part[4]);
        _CompletionPeriod = Int32.Parse(part[5]);
        _Completed = bool.Parse(part[6]);

        ChecklistGoal checklist = new ChecklistGoal(_name, _description, _value, _Completed, _Executed, _CompletionPeriod, _bonus);
        return checklist;

    }



    public override void ListGoal()
    {

        string Checkbox = "";
        if (_Completed)
        {
            Checkbox = "[X]";
        }

        else if (!_Completed)
        {
            Checkbox = "[ ]";
        }
        Console.WriteLine($"{Checkbox} {_name} ({_description})  --currently completed: {_Executed}/{_CompletionPeriod}");
    }

    public override int RecordEvent()
    {
        _Executed++;
        total += _value;

        if (_Executed == _CompletionPeriod)
        {
            total += _bonus;
            _Completed = true;
            Console.WriteLine($"Your goal has been completed and you get a bonus of +{_bonus}!");
        }

        return _pointsPerCompletion;
    }


}