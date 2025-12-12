using System;

class Program
{
    static void Main(string[] args)
    {
        Exercise johnsJog = new Running(50, "05 December 2023", 10);
        Exercise bensBike = new Cycling(15, "15 December 2024", 60);
        Exercise samsSwim = new Swimming(100, "22 September 2025", 5);

        List<Exercise> exercises = new List<Exercise>();
        exercises.Add(johnsJog);
        exercises.Add(bensBike);
        exercises.Add(samsSwim);

        foreach (Exercise exercise in exercises)
        {
            exercise.Summary();
        }
    }
}