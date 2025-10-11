public class Prompt
{
    public List<string> _promptList = new List<string>();
    
    public string GeneratePrompt()
    {
        _promptList.Add("Did you make a friend today? If so, who?");
        _promptList.Add("Where did you spend the most time today?");
        _promptList.Add("What was the craziest thing you did today?");
        _promptList.Add("What was your favorite activity today?");
        _promptList.Add("If you could fix one mistake you made today, what would it be?");
        
        Random random = new Random();

        int PromptNumber = random.Next(4);

        string RandomPrompt = _promptList[PromptNumber];
        return RandomPrompt;
    }
}