public class EternalGoal : Goal
{

    private string GoalType = "Eternal Goal";


    public EternalGoal(string name, string description, int value) : base(name, description, value)
    {
    }

    public EternalGoal(string data) : base(data)
    {
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
        return _value; ;
    }

    public override string Status()
    {
        string stats = $"{GoalType}|{_name}|{_description}|{_value}";
        return stats;
    }
    public override void ListGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override Goal StringData(string data)
    {
        string[] part = data.Split("|");
        _name = part[1];
        _description = part[2];
        _value = Int32.Parse(part[3]);

        EternalGoal eternal = new EternalGoal(_name, _description, _value);
        return eternal;
    }
}