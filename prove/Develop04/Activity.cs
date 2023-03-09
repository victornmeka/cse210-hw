abstract class Activity
{
    protected int duration;

    public void Run()
    {
        StartingMessage();
        Pause(3);
        DoActivity();
        Pause(3);
        EndingMessage();
        Pause(3);
    }

    protected void StartingMessage()
    {
        Console.WriteLine($"Starting {GetType().Name} ...");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Prepare");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(" +");
            Thread.Sleep(200);
        }
        Console.WriteLine();
        Pause(3);
    }


    protected abstract void DoActivity();

    protected void EndingMessage()
    {
        Console.WriteLine($"Good job! You completed {GetType().Name}  for {duration} seconds.");
    }

    protected void Pause(int Seconds, bool Timer = true)
    {
        if (Timer)
        {
            for (int i = Seconds; i >= 1; i--)
            {
                Console.Write("\r{0} ", new string(' ', Console.WindowWidth - 1));
                Console.Write("\r{0} seconds remaining", i);
                Thread.Sleep(1000);
            }
            Console.Write("\r{0}\r", new string(' ', Console.WindowWidth - 1));
        }
        else
        {
            for (int i = 0; i < Seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }

}