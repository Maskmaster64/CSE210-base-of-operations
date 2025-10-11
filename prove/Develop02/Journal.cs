

public class Journal
{
    public string _date;
    public string _fileName;
    public List<string> _jornal = new List<string>();

    public void WriteEntry()
    {
        Prompt prompt = new Prompt();
        string RandomPrompt = prompt.GeneratePrompt();
        Console.WriteLine(RandomPrompt);
        string JournalEntry = Console.ReadLine();
        string FullEntry = $"{RandomPrompt} \n{JournalEntry}";
        _jornal.Add(FullEntry);
    }

    public void DisplayJornal()
    {
        foreach (string entry in _jornal)
        {
            Console.WriteLine(entry);
        }
    }


    public void SaveJournal()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (string entry in _jornal)
            {
                outputFile.WriteLine(entry);
            }
        }

    }
    
    public void LoadJornal()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        _jornal.Clear();

        int LineCount = 1;

        string LineStr = "";

        foreach (string line in lines)
        {
            if (LineCount % 2 == 1)
            {
                LineStr = line;
            }

            else if (LineCount % 2 == 0)
            {
                _jornal.Add($"{LineStr} \n{line}");
            }

            LineCount = LineCount + 1;
        }
    }
}