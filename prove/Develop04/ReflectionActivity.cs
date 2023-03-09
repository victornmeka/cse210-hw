class ReflectionActivity : Activity
{
    private static List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    private static List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "How can you keep this experience in mind in the future? "
        };


    protected override void DoActivity()
    {

        int promptIndex = new Random().Next(prompts.Count);
        Console.WriteLine(prompts[promptIndex]);

        for (int i = 0; i < duration; i++)
        {
            Console.Write("Reflecting");
            for (int j = 0; j < i % 3 + 1; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            Pause(1);
        }

        Console.WriteLine("Now, answer one of the following questions to help deepen your reflection:");
        int questionIndex = new Random().Next(questions.Count);
        Console.WriteLine(questions[questionIndex]);
        string response = Console.ReadLine();
    }
}