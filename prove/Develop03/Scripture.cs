using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference lb_reference;
    private List<Word> lb_words;

    public Scripture(Reference reference, string text)
    {
        lb_reference = reference;
        lb_words = new List<Word>();

        string[] splitText = text.Split(" ");

        foreach (string wordString in splitText)
        {
            lb_words.Add(new Word(wordString));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHiddenThisRound = 0;

        while (wordsHiddenThisRound < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = random.Next(lb_words.Count);

            if (!lb_words[randomIndex].IsHidden())
            {
                lb_words[randomIndex].Hide();
                wordsHiddenThisRound++;
            }
        }
    }

    public string GetDisplayText()
    {
        string fullText = $"{lb_reference.GetDisplayText()} ";

        List<string> displayWords = new List<string>();
        foreach (Word word in lb_words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return fullText + string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in lb_words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}