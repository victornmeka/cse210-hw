public class GenerateActivities
{
    public static List<Activity> Activities()
    {
        DateTime date = DateTime.Now;

        Activity running = new Running(date, 30, 3);
        Activity cycling = new Cycling(date, 30, 12);
        Activity swimming = new Swimming(date, 30, 40);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        return activities;
    }
}