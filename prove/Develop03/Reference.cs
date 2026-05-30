public class Reference
{
    private string lb_book;
    private int lb_chapter;
    private int lb_verse;
    private int lb_endVerse;

    public Reference(string book, int chapter, int verse)
    {
        lb_book = book;
        lb_chapter = chapter;
        lb_verse = verse;
        lb_endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        lb_book = book;
        lb_chapter = chapter;
        lb_verse = startVerse;
        lb_endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (lb_endVerse == 0 || lb_verse == lb_endVerse)
        {
            return $"{lb_book} {lb_chapter}:{lb_verse}";
        }
        else
        {
            return $"{lb_book} {lb_chapter}:{lb_verse}-{lb_endVerse}";
        }
    }
}