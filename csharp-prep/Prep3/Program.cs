using System;

class Program
{
    static void Main(string[] args)
    {
        /* The next two lines will generate a random number*/
        Random randomGenerator = new Random();
        int SecretNumber = randomGenerator.Next(1, 100);
        /* This next line will create a variable for the guess
        I set the number to 0 because 0 is not included within
        the range of 1 and 100*/
        int UserNumber = 0;

        
        while (SecretNumber != UserNumber)
        {
            Console.Write("Guess a number between 1 and 100: ");
            string UserGuess = Console.ReadLine();
            UserNumber = int.Parse(UserGuess);


            if (UserNumber > SecretNumber)
            {
                Console.WriteLine("Guess lower.");
            }


            else if (UserNumber < SecretNumber)
            {
                Console.WriteLine("Guess higher.");
            }


            else
            {
                Console.WriteLine("You guessed my number");
            }
        }
    }
}