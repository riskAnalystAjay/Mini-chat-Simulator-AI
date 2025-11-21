using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Mini Chat Simulator ===");
        Console.WriteLine("Type anything (type 'exit' to stop)\n");

        while (true)
        {
            Console.Write("You: ");
            string user = Console.ReadLine()?.ToLower() ?? "";

            if (user == "exit") break;

            string bot = Reply(user);
            Console.WriteLine("AI: " + bot + "\n");
        }
    }

    static string Reply(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return "Hmm say something 😄";

        // simple mood detectors
        if (text.Contains("happy") || text.Contains("good") || text.Contains("love"))
            return "Nicee! I like your vibe 😄🔥";

        if (text.Contains("sad") || text.Contains("tired") || text.Contains("bad"))
            return "Aww… you okay? I'm here 💛";

        if (text.Contains("angry") || text.Contains("hate"))
            return "Relax a bit… wanna talk about it? 😐";

        // greetings
        if (text.StartsWith("hi") || text.StartsWith("hey") || text.StartsWith("hello"))
            return "Heyy! What's up? 😄";

        // questions
        if (text.Contains("?"))
            return "Good question… what do YOU think? 🤔";

        // random small replies
        string[] replies =
        {
            "Interesting… tell me more 👀",
            "Ohh really? 👀",
            "Hmm okay okay 😄",
            "I'm listening… go on!",
            "Lol that’s funny 😂"
        };

        Random r = new Random();
        return replies[r.Next(replies.Length)];
    }
}