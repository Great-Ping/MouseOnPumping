namespace MouseOnPumping;

public class Question
{
    public int UserAnswer;
    public int CorrectAnswer;
    public string Image = string.Empty;
    public string Theme = string.Empty;
    public string Title = string.Empty;
    public List<string> AnswerOptions { get; set; } = [];

    public override string ToString()
    {
        return Theme;
    }
}
