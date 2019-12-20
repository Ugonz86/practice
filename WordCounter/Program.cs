using System;
using WordCounter.Models;
class Program
{
    private static string _wordUserInput;
    private static string _sentenceUserInput;

    private static void wordFinder()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\nTo start, please enter a word: ");
        string userInput = Console.ReadLine();
        bool validInput = RepeatCounter.ValidInput(userInput);

        if (!validInput)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid word. Please try again.");
            Console.ResetColor();

            wordFinder();
        }
        else
        {
            _wordUserInput = userInput;
        }
    }

    private static void sentenceFinder()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\nPlease enter a sentence: ");
        string userInput = Console.ReadLine();

        if (userInput.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Try again. Please write a sentence.");
            Console.ResetColor();

            sentenceFinder();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            _sentenceUserInput = userInput;
        }
    }

    private static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("");
        Console.WriteLine("Let's count matching words in a sentence!");

        wordFinder();
        sentenceFinder();

        RepeatCounter newCounter = new RepeatCounter(_wordUserInput, _sentenceUserInput);
        
        int wordCount = newCounter.characterCount();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nThe word \"{_wordUserInput}\" appears {wordCount} time(s)!");
        Console.WriteLine("");
        Console.ResetColor();

        Main();
    }
}