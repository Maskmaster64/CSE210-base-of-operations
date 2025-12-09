using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, string chapter, string StartVerse, string EndVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = StartVerse;
        _endVerse = EndVerse;
    }

    public void Display()
    {
        string CapitalBook = char.ToUpper(_book[0]) + _book.Substring(1);

        if (_endVerse != null)
        {
            Console.WriteLine($"{CapitalBook} {_chapter}:{_startVerse}-{_endVerse}");
        }
        
        else if (_endVerse == null)
        {
            Console.WriteLine($"{CapitalBook} {_chapter}:{_startVerse}");
        }
    }
}