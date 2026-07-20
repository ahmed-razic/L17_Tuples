namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string NNN, int LLL, int PPP) score1 = GetScore();
            (string, int, int) score2 = GetOtherScore();
            Console.WriteLine();
            Console.WriteLine(score1.NNN);
            Console.WriteLine(score2.Item1);

            Console.WriteLine();
            DisplayScore(score1);
            DisplayScore(score2);

            (string Name, int Level, int Points) GetScore() => ("Ahmed", 13, 100);

            (string N, int L, int P) GetOtherScore()
            {
                return ("Ibrahim", 17, 200);
            }

            void DisplayScore((string Name, int Level, int Points) score)
            {
                Console.WriteLine($"\nName: {score.Name}\nLevel: {score.Level}\nPoints: {score.Points}\n");
            }
        }
    }
}
