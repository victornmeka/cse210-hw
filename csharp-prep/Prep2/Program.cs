using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to your course grading system");
        string letter = "";
        string sign = "";
        Console.Write("Please enter your grading percentage: ");
        int userGradeInput = int.Parse(Console.ReadLine());
        if (userGradeInput >= 90)
        {
            letter = "A";
            int getSign = userGradeInput % 10;
            if (getSign <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (userGradeInput >= 80)
        {
            letter = "B";
            int getSign = userGradeInput % 10;
            if (getSign >= 7)
            {
                sign = "+";
            }
            else if (getSign <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (userGradeInput >= 70)
        {
            letter = "C";
            int getSign = userGradeInput % 10;
            if (getSign >= 7)
            {
                sign = "+";
            }
            else if (getSign <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (userGradeInput >= 60)
        {
            letter = "D";
            int getSign = userGradeInput % 10;
            if (getSign >= 7)
            {
                sign = "+";
            }
            else if (getSign <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (userGradeInput < 60)
        {
            letter = "F";
            int getSign = userGradeInput % 10;
            if (getSign <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        Console.WriteLine($"Your Grade is: {letter}{sign}");

        if (userGradeInput > 70)
        {
            Console.WriteLine("Congratulations You passed!!!");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next semester.");
        }


    }
}