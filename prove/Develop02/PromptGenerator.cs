using System;
using System.Collections.Generic;

public class PromptGenerator{
    public string GeneratePrompt() {
        Random rnd = new();

        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?"
        };

        int index = rnd.Next(prompts.Count);

        return prompts[index];
    }
}