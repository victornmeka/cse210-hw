using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = GenerateActivities.Activities();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}

