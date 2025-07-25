using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        // _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;

    }

    public bool IsHidden()
    {
        return _isHidden;

    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            StringBuilder hiddenText = new StringBuilder();
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenText.Append("_");
            }
            return $"{hiddenText.ToString()}";
        
        }
        else
        {
            return $"{_text}";

        }
    }
}