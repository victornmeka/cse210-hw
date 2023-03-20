public class Goal
{
    protected string _name;
    protected string _description;
    public int _pointsPerCompletion { get; set; }
    public int total { get; set; }
    public int _value;
    protected string _data;


    public Goal() { }


    public Goal(string name, string description, int value)
    {
        _name = name;
        _description = description;
        _value = value;
    }

    public virtual string GetName()
    {
        return null;
    }

    public virtual string GetDescription()
    {
        return null;
    }

    public virtual int GetPoints()
    {
        return 0;
    }

    public virtual int GetCompletionPeriod()
    {
        return 0;
    }
    public virtual string Status()
    {
        return null;
    }

    public virtual Goal StringData(string data)
    {
        return null;
    }

    public virtual void ListGoal()
    {
    }
    public Goal(string data)
    {
        string[] part = data.Split("|");
        _data = part[0];
        _name = part[1];
        _description = part[2];
        _value = Int32.Parse(part[3]);
    }
    public virtual int RecordEvent()
    {

        return _pointsPerCompletion;
    }

}