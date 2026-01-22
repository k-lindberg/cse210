public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private static Random rndWord = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        char[] separators = { ' ', ',', ';', ':', '.', '!', '?', '"' };
        string[] splitWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (string wordText in splitWords)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rndWord.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string refDisplay = _reference.GetDisplayText();

        List<string> wordText = new List<string>();

        foreach (Word word in _words)
        {
            wordText.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", wordText);

        return $"{refDisplay} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public int CountVisibleWords()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                count++;
        }
        return count;
    }
}