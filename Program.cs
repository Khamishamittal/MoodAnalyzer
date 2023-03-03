namespace MoodAnalyzer
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem");

            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);
            Console.WriteLine(mood.AnalyzeMood());
        }
    }
    }
