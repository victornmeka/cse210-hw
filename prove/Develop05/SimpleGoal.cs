public class SimpleGoal : Goal
{
    private string GoalType = "Simple Goal";

    private bool _Completed;

    public SimpleGoal(string name, string description, int value, bool Completed)
        : base(name, description, value)
    {
        _Completed = Completed;
    }

    public SimpleGoal(string data) : base(data)
    {

        string[] part = data.Split("|");

        _Completed = bool.Parse(part[4]);
    }

    public override string Status()
    {
        string stats = $"{GoalType}|{_name}|{_description}|{_value}|{_Completed}";
        return stats;
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


    public override SimpleGoal StringData(string data)
    {
        string[] part = _data.Split("|");

        _name = part[1];
        _description = part[2];
        _value = Int32.Parse(part[3]);
        _Completed = bool.Parse(part[4]);

        SimpleGoal simple = new SimpleGoal(_name, _description, _value, _Completed);

        return simple;

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
        Console.WriteLine($"{Checkbox} {_name} ({_description})");
    }
    public override int RecordEvent()
    {
        _Completed = true;
        return 0;
    }


}