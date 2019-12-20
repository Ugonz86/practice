using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string WordInput { get; set; }
        public string SentenceInput { get; set; }

        public RepeatCounter(string word, string sentence)
        {
            WordInput = word;
            SentenceInput = sentence;
        }

    }
}