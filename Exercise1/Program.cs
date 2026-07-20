namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int x, string y, double z) point = (3, "four", 5.5);

            Console.WriteLine(point);
            Console.WriteLine(point.y);
            Console.WriteLine(point.Item1);

            Console.WriteLine();

            (string Name, int Points, int Level) score1 = ("Ahmed", 12556, 13);
            (string, int, int) score2 = score1;

            Console.WriteLine(score1);
            Console.WriteLine(score2);
            Console.WriteLine(score1.Name);
            Console.WriteLine(score2.Item1);

            if (score1 == score2) Console.WriteLine("score1 and score2 are equal.");
            score2.Item3 = 15;
            if (score1 == score2)
                Console.WriteLine("score1 and score2 are equal.");
            else
                Console.WriteLine("score1 and score2 are not equal");
        }
    }
}
