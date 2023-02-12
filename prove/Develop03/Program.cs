using System;

class Program
{
    static void Main(string[] args)
    {
        //Store a library of scriptures instead of one(Wxceeds requirements)
        List<Scripture> scriptureLibrary = new List<Scripture>();
        scriptureLibrary.Add(new Scripture(new ScriptureReference("John 3:16"), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptureLibrary.Add(new Scripture(new ScriptureReference("Proverbs 3:5-6"), "5. Trust in the Lord with all thine heart; and lean not unto thine own understanding: 6. In all thy ways acknowledge him and he shall direct thy paths."));
        scriptureLibrary.Add(new Scripture(new ScriptureReference("Psalm 23:6"), "Surely goodness and mercy shall follow me all the days of my life: and I will dwell in the house of the Lord for ever."));

        //Scripture is randomly chosen from the library of scriptures (Exceeds requirement)
        Random random = new Random();
        int scriptureIndex = random.Next(0, scriptureLibrary.Count);
        Scripture scripture = scriptureLibrary[scriptureIndex];

        while (scripture.GetWordsLeft() > 0)
        {
            scripture.Display();
            Console.WriteLine("Press enter to hide more words or type quit to end the program.");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            scripture.HideWords();
            Console.Clear();
        }
    }
}