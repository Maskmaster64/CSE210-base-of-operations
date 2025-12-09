public class Scripture
{
    private List<Word> _scripture;

    public void DisplayScripture()
    {
        string scriptureText = "";
        foreach (Word word in _scripture)
        {
            scriptureText = scriptureText + word.ReturnWord();
        }
        Console.WriteLine(scriptureText);
    } 
}