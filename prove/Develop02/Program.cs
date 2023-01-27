using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Random rand = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Develop02!");
        while (true)
        {
            //Display menu
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    WriteEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    SaveJournal();
                    break;
                case 4:
                    LoadJournal();
                    break;
                case 5:
                    return;
            }
        }
    }
    class Entry  //Entry class contains properties of prompt, response and date
    {
        public string promptQuestion;
        public string response;
        public DateTime date;
        public Entry(string promptQuestion, string response, DateTime date)
        {
            this.promptQuestion = promptQuestion;
            this.response = response;
            this.date = date;
        }
    }

    static List<Entry> journal = new List<Entry>(); //Initialize a list of journal entries
    static List<string> promptQuestions = new List<string>() //Create a new list of prompts
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are you grateful for?"
    };


    static void WriteEntry() //write a new entry
                             //If the user select "1" in the menu, it will call this method
    {
        int promptIndex = rand.Next(promptQuestions.Count);
        string prompt = promptQuestions[promptIndex];

        //Display prompt and get response
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        //Create new entry
        Entry entry = new Entry(prompt, response, DateTime.Now);

        //Add entry to journal
        journal.Add(entry);
    }



    static void DisplayJournal()  //Method to display the journal
                                  // If the user selects "2", it will call this method
    {
        if (journal.Count == 0)
        {
            Console.WriteLine("No entries in journal");
            return;
        }

        //Iterate through journal entries
        foreach (Entry entry in journal)
        {
            Console.WriteLine(entry.promptQuestion);
            Console.WriteLine(entry.response);
            Console.WriteLine(entry.date);
            Console.WriteLine();
        }
    }

    static void SaveJournal() //Method to save a journal
    {
        Console.WriteLine("Enter a filename:");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in journal)
            {
                writer.WriteLine(entry.promptQuestion);
                writer.WriteLine(entry.response);
                writer.WriteLine(entry.date);
                writer.WriteLine();
            }
        }
    }

    static void LoadJournal() //Method to load a journal
    {
        Console.WriteLine("Enter a filename:"); //Request filename is the option is selected
        string filename = Console.ReadLine();
        journal.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string prompt = reader.ReadLine();
                string response = reader.ReadLine();
                DateTime date = DateTime.Parse(reader.ReadLine());
                Entry entry = new Entry(prompt, response, date);
                journal.Add(entry);
            }
        }
    }

}