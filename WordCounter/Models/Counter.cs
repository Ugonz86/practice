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

        public int characterCount()
        {
            int wordCount = 0;

            string[] wordArray = SentenceInput.Split(' ');
            for (int i = 0; i < wordArray.Length; i++)
            {
                foreach (char sentenceChar in _specialCharacters)
                {
                    if (wordArray[i].Contains(sentenceChar))
                    {
                        wordArray[i] = wordArray[i].Trim(_specialCharacters);
                    }
                }

                if (WordInput == wordArray[i])
                {
                    wordCount++;                }
            }
            return wordCount;
        }
    }
}