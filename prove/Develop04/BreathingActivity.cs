class BreathingActivity : Activity
{
    protected override void DoActivity()
    {

        for (int i = 0; i < duration; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }
            Pause(3);
        }
    }
}