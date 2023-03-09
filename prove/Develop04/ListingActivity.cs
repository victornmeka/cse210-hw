class ListingActivity : Activity
{
    protected override void DoActivity()
    {

        List<string> responses = new List<string>();
        for (int i = 0; i < duration; i++)
        {
            Console.Write("Listing");
            for (int j = 0; j < i % 3 + 1; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            Pause(1);

            //list of prompts
            List<string> Questions = new List<string>()
            {
                "Who are people that you appreciate? ",
                "What are personal strengths of yours? ",
                "Who are people that you have helped this week? ",
                "When have you felt the Holy Ghost this month? ",
                "Who are some of your personal heroes? "
            };
            if (i % 10 == 0)
            {
                int QuestionIndex = new Random().Next(Questions.Count);
                Console.WriteLine(Questions[QuestionIndex]);
                string response = Console.ReadLine();
                responses.Add(response);
            }
        }

        Console.WriteLine("Here are all your response:");
        foreach (string line in responses)
        {
            Console.WriteLine($"-  {line}");
        }
    }
}