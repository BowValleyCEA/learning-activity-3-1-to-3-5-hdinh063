namespace MyApplication
{
    public class LA35
    {
        public static void Run()
        {
            List<int> highScores = new List<int> { 100000, 200000, 150000, 300000, 250000 };
            double average = CalculateAverage(highScores);
            Console.WriteLine($"Average Score: {average}");
        }

        private static double CalculateAverage(List<int> scores)
        {
            double sum = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                sum += scores[i];
            }
            return sum / scores.Count;
        }
    }
}