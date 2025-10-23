using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Gary", "1234");
        Schedule schedule = new Schedule(student);

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine();
        }
    }
}