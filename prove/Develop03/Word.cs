public class Word
{
    private string _currentWord;
    private bool _isBlank;

    public Word(string word)
    {
        _currentWord = word;
        _isBlank = false;
    }

    public void MakeBlank()
    {
        _isBlank = true;
        int wordLength = _currentWord.Length;
        _currentWord = "";
        for (int i = 0; i < wordLength; i++)
        {
            _currentWord = _currentWord + "_";
        }
    }
    
    public string ReturnWord()
    {
        string word = _currentWord;
        return word;
    }
}