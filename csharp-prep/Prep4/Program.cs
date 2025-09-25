using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finnished.");
        int UserNumber = 1;
        List<int> NumberList = new List<int>();
        int ListCount = 0;
        int ListSum = 0;
        int LargestNumber = 0;
        while (UserNumber != 0)
        {
            Console.Write("Enter number: ");
            UserNumber = int.Parse(Console.ReadLine());
            if (UserNumber != 0)
            {
                NumberList.Add(UserNumber);
                ListCount = ListCount + 1;
            }

        }
        foreach (int number in NumberList)
        {
            ListSum = ListSum + number;
            if (number > LargestNumber)
            {
                LargestNumber = number;
            }
        }
        float ListAverage = ListSum / (float)ListCount;
        Console.WriteLine($"The sum is: {ListSum}");
        Console.WriteLine($"The average is: {ListAverage}");
        Console.WriteLine($"The largest number is: {LargestNumber}");
    }
}