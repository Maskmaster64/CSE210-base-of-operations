using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int JournalOption = 0;

        Prompt prompt = new Prompt();

        // prompt._promptList.Add("Did you make a friend today? If so, who?");
        // prompt._promptList.Add("Where did you spend the most time today?");
        // prompt._promptList.Add("What was the craziest thing you did today?");
        // prompt._promptList.Add("What was your favorite activity today?");
        // prompt._promptList.Add("If you could fix one mistake you made today, what would it be?");

        Journal journal = new Journal();

        while (JournalOption != 5)
        {
            Console.WriteLine("Type the number corrisponding with the action you want to do.");
            Console.WriteLine("1: Write a new entry");
            Console.WriteLine("2: Display your journal");
            Console.WriteLine("3: Save your journal to local file");
            Console.WriteLine("4: Load journal from local file");
            Console.WriteLine("5: Quit program");

            string UserChoice = Console.ReadLine();
            JournalOption = int.Parse(UserChoice);

            if (JournalOption == 1)
            {
                journal.WriteEntry();
            }

            else if (JournalOption == 2)
            {
                journal.DisplayJornal();
            }

            else if (JournalOption == 3)
            {
                Console.Write("Please provied the name of the file you wish to save on: ");
                string FileName = Console.ReadLine();
                journal._fileName = FileName;

                journal.SaveJournal();
            }

            else if (JournalOption == 4)
            {
                Console.Write("Please provide the name of the file you wish to load: ");
                string FileName = Console.ReadLine();
                journal._fileName = FileName;

                journal.LoadJornal();
            }

            else if (JournalOption == 5)
            {
                Console.WriteLine("Thank you for using your journal, have a great day.");
            }

            else
            {
                Console.WriteLine("That is an invalid option, please use a valid option.");
            }
        }
    }
}