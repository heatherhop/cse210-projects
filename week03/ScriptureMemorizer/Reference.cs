using System.IO;
using System.Text.Json;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // public string GetBook()
    // {
    //     return _book;
    // }

    // public void SetBook(string book)
    // {
    //     _book = book;
    // }


    // public int GetChapter()
    // {
    //     return _chapter;
    // }

    // public void SetChapter(int chapter)
    // {
    //     _chapter = chapter;
    // }

    // public int GetVerse()
    // {
    //     return _verse;
    // }

    // public void SetVerse(int verse)
    // {
    //     _verse = verse;
    // }

    // public int GetEndVerse()
    // {
    //     return _endVerse;
    // }

    // public void SetEndChapter(int endVerse)
    // {
    //     _endVerse = endVerse;
    // }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

    }

}