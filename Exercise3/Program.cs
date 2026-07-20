using System.ComponentModel;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            int[] GetHighScores()
            {
                return new int[3] { 1, 2, 3 };
            }

            int[] myArray = GetHighScores();

            Console.WriteLine(myArray[0] + " " + myArray[1] + " " + myArray[2]);


            (string Name, int Level, int Points)[] GetScores()
            {
                return new (string, int, int)[3]
                {
                    ("Ahmed", 33, 113),
                    ("Ibrahim", 11, 203),
                    ("Merjema", 17, 55)
                };
            }

            (string Name, int Level, int Points)[] highScores = GetScores();

            Console.WriteLine(highScores[0] + " " + highScores[1] + " " + highScores[2]);

            (string name, int level, int points) = highScores[2];

            Console.WriteLine($"Name {name}, Level {level}, Points {points}");

            //swap values
            int x = 5;
            int y = 7;
            Console.WriteLine($"x {x}, y {y}");

            (x, y) = (y, x);
            Console.WriteLine($"x {x}, y {y}");


            //equality of tuples
            (int, int) a = (1, 3);
            (int, int) b = (1, 3);

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            (int, int, string) m = (1, 3, "one");
            (int, int, string) n = (1, 3, "one");
            Console.WriteLine(m == n);
        }
    }
}
