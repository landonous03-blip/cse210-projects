public class Word
{
    private string lb_text;
    private bool lb_isHidden;

    public Word(string text)
    {
        lb_text = text;

        lb_isHidden = false;
    }

    public void Hide()
    {
        lb_isHidden = true;
    }

    public void Show()
    {
        lb_isHidden = false;
    }

    public bool IsHidden()
    {
        return lb_isHidden;
    }

    public string GetDisplayText()
    {
        if (lb_isHidden)
        {
            return new string('_', lb_text.Length);
        }
        else
        {
            return lb_text;
        }
    }
}