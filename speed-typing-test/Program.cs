using Bogus.DataSets;
using System;
using System.Diagnostics;

/// <summary>
/// Speed typing test application
/// </summary>
public class SpeedTypingTest
{
    /// <summary>
    /// Generates the paragraph for typing test
    /// </summary>
    /// <returns>The paragraph</returns>
    public static System.String ParagraphGeneration()
    {
        var text = new Lorem("en");
        Console.WriteLine("How many sentences ? ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();
        return text.Paragraphs(length);
    }

    /// <summary>
    /// Calculates the typing time and accuracy
    /// </summary>
    /// <param name="paragraph"></param>
    /// <returns>The time it takes to type and the accuracy in a tuple</returns>
    public static Tuple<TimeSpan, float> getTypingTimeAccuracy(System.String paragraph)
    {
        Console.WriteLine(paragraph + "\n");
        Stopwatch stopwatch = Stopwatch.StartNew();
        string userTyping = Console.ReadLine();
        stopwatch.Stop();
        float correctCount = 0;
        for (int i = 0; i < Math.Min(paragraph.Length, userTyping.Length); i++)
        {
            if (paragraph[i] == userTyping[i])
            {
                correctCount++;
            }
        }
        correctCount = (correctCount / (float)paragraph.Length) * 100;
        TimeSpan time = stopwatch.Elapsed;
        return new Tuple<TimeSpan, float>(time, correctCount);
    }

    /// <summary>
    /// Outputs the generated paragraph, time taken, accuracy and WPM
    /// </summary>
    public static void Main()
    {
        string paragraph = ParagraphGeneration();
        Tuple<TimeSpan, float> results = getTypingTimeAccuracy(paragraph);
        Console.WriteLine("Time elapsed: " + results.Item1 + "\n");
        Console.WriteLine("Accuracy: " + Math.Round(results.Item2, 2) + "%\n");
        Console.WriteLine("WPM: " + Math.Round(paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length / results.Item1.TotalMinutes));
    }
}
