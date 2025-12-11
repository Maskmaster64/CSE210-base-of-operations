using System;

class Program
{
    static void Main(string[] args)
    {
        Event party = new Event("Party", "it is a party to celebrate stuff", "December 15, 2026", "6:30 pm", "23 Place ST, Portland, OR");

        Lecture devotional = new Lecture("Jeffrey R. Holland", 450, "Devotional", "A spirit led devotional with guest speaker Jeffrey R. Holland", "January 10th, 2026", "4:00 pm", "101 E Viking St, Rexburg, ID 83460");

        Reception marriage = new Reception("Someone@gmail.com", "Marriage reception", "A party to celebrate the marriage of Someone and That Person", "Febuary 19, 2026", "3:00 pm", "A street Rd, City, State");

        Outdoor barbaque = new Outdoor("Partially Cloudy", "Barbaque", "A barbaque party for the neighborhood", "March 22nd, 2026", "11:30 am", "57 Richard Rd, Great Falls, MT");

        party.BasicDetails();
        Console.WriteLine("");
        party.ShortDescription();
        Console.WriteLine("");
        devotional.FullDetails();
        Console.WriteLine("");
        devotional.ShortDescription();
        Console.WriteLine("");
        marriage.FullDetails();
        Console.WriteLine("");
        marriage.ShortDescription();
        Console.WriteLine("");
        barbaque.FullDetails();
        Console.WriteLine("");
        barbaque.ShortDescription();
    }
}