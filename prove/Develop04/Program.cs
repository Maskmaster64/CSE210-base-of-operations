using System;

class Program
{
    static void Main(string[] args)
    {
        bool endProgram = false;
        // this instance of activity is used just for the spinner
        Activity spin = new Activity(0, "", "");

        Console.WriteLine("Welcome to the Mindfullness program!");
        
        while (endProgram == false)
        {
            spin.Spinner(2);
            Console.WriteLine("Here are your options:");
            Console.WriteLine("1: Breathing activity");
            Console.WriteLine("2: Reflection activity");
            Console.WriteLine("3: Listing activity");
            Console.WriteLine("4: Quit program");
            spin.Spinner(3);
            Console.WriteLine("Type the number corisponding with what you want to do.");
            string userString = Console.ReadLine();
            Console.WriteLine("");

            if (userString == "1")
            {
                string bDescription = "This activity will help you relax by walking your through breathing in and out slowly.\n Clear your mind and focus on your breathing.";
                Console.WriteLine("You have chosen the Breathing activity.");
                spin.Spinner(2);
                Console.WriteLine("How long in seconds do you want to do this activity for");
                string durationStr = Console.ReadLine();
                int durationInt = int.Parse(durationStr);
                Breathing breathing = new Breathing(durationInt, "Breathing", bDescription);
                breathing.BreathingActivity();
            }

            else if (userString == "2")
            {
                string rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.\n This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Console.WriteLine("You have chosen the Reflection activity.");
                spin.Spinner(2);
                Console.WriteLine("How long in seconds do you want to do this activity for");
                string durationStr = Console.ReadLine();
                int durationInt = int.Parse(durationStr);
                Reflection reflection = new Reflection(durationInt, "Reflection", rDescription);
                reflection.ReflectionActivity();
            }

            else if (userString == "3")
            {
                string lDescription = "This activity will help you reflect on the good things in your life by having\n you list as many things as you can in a certain area.";
                Console.WriteLine("You have chosen the Listing activity.");
                spin.Spinner(2);
                Console.WriteLine("How long in seconds do you want to do this activity for");
                string durationStr = Console.ReadLine();
                int durationInt = int.Parse(durationStr);
                Listing listing = new Listing(durationInt, "Listing", lDescription);
                listing.ListingActivity();
            }

            else if (userString == "4")
            {
                Console.WriteLine("Thank you for useing the mindfullness program, have a great day!");
                endProgram = true;
            }

            else
            {
                Console.WriteLine("That is not a valid option.");
            }
            
        }
    }
}