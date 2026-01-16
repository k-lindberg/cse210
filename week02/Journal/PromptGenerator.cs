using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What is something you're grateful for right now?",
        "Who made a positive impact on your day, and why?",
        "What is something you want to improve tomorrow?",
        "what is a goal you want to focus on this week?"
    };

    public string GetRandomPrompt()
    {
        Random randPrompt = new Random();
        int index = randPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}