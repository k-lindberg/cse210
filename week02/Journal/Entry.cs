public class Entry
{
    public string _date;
    public string _mood;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Mood: {_mood} \nPrompt: {_promptText}\n{_entryText}");
    }
}