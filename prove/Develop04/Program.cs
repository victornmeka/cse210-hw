using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness Program.");
            Console.WriteLine();
            // Display menu options
            List<string> Menu = new List<string>()
            {
            "1. Breathing",
            "2. Reflecting",
            "3. Listing",
            "4. Quit"

            };
            foreach (string option in Menu)
            {
                Console.WriteLine(option);
            }

            // Get user input
            Console.Write("Please select an option: ");
            string UserChoice = Console.ReadLine();

            // Validate input
            while (UserChoice != "1" && UserChoice != "2" && UserChoice != "3" && UserChoice != "4")
            {
                Console.Write("Invalid choice. Please select a number from the option. ");
                UserChoice = Console.ReadLine();
            }

            //if the  user selects the quit option
            if (UserChoice == "4")
            {
                Console.WriteLine("You session is over, Thank you & Goodbye.");
                return;
            }

            // Create activity based on user input
            Activity activity;
            if (UserChoice == "1")
            {
                activity = new BreathingActivity();
                Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            }
            else if (UserChoice == "2")
            {
                activity = new ReflectionActivity();
                Console.WriteLine("This activity will help you reflect on a past experience that was meaningful to you. Choose one of the following prompts and spend the duration reflecting on it.");
            }
            else if (UserChoice == "3")
            {
                activity = new ListingActivity();
                Console.WriteLine("This activity will help you clear your mind by listing out everything that comes to mind. Start by focusing on your breath and letting thoughts come and go. When a thought sticks, write it down and return to focusing on your breath.");
            }
            else
            {
                activity = null;
            }
            // Run activity
            if (activity != null)
            {
                activity.Run();
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
        }
    }

}