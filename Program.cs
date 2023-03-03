namespace MoodAnalyzer
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem");

            AnalyseAndRespond mood = new AnalyseAndRespond();
            string message = "I am in Any Mood";
            Console.WriteLine(mood.AnalyzeMood(message));
        }
    }
    }
