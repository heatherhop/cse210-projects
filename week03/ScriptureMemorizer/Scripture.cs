
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        char[] delimiters = new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?', '"', '(', ')', '-', '_', '&', '`' };
        string[] eachWordInText = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        foreach (string eachWord in eachWordInText)
        {
            Word newWord = new Word(eachWord);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> notHiddenWords = new List<Word>();
        Random random = new Random();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                notHiddenWords.Add(word);
            }
        }
        if (notHiddenWords.Count == 0 || numberToHide <= 0)
        {
            return;
        }

        int wordsToHide = Math.Min(numberToHide, notHiddenWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomNumber = random.Next(0, notHiddenWords.Count);
            notHiddenWords[randomNumber].Hide();
            notHiddenWords.RemoveAt(randomNumber);
        }
    }

    public string GetDisplayText()
    {
        StringBuilder displayScriptureText = new StringBuilder();
        displayScriptureText.Append(_reference.GetDisplayText());
        displayScriptureText.Append(" ");

        foreach (Word word in _words)
        {
            displayScriptureText.Append(word.GetDisplayText());
            displayScriptureText.Append(" ");
        }
        return displayScriptureText.ToString();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}