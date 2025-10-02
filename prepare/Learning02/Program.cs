using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Apple";
        job1._jobTitle = "Manager";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._companyName = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2019;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Ashton";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}