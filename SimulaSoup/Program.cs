using System.Net.Mail;
using System.Xml;

namespace SimulaSoup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (Food food, Ingredients ingredient, Seasoning seasoning) recipe = (Food.Stew, Ingredients.Chicken, Seasoning.Spicy);
            int answer1 = -1, answer2 = -1, answer3 = -1;

            Console.WriteLine("Simula's Soup\n");

            while (answer1 != 0 && answer2 != 0 && answer3 != 0 && answer1 != 1 && answer1 != 2 && answer1 != 3)
            {
                Console.Write("Select Food (0 - exit, 1 - Soup, 2 - Stew, 3 - Gumbo): ");
                answer1 = int.Parse(Console.ReadLine());

                if (answer1 == 0)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else if (answer1 == 1)
                    recipe.food = Food.Soup;
                else if (answer1 == 2)
                    recipe.food = Food.Stew;
                else if (answer1 == 3)
                    recipe.food = Food.Gumbo;
            }

            while (answer1 != 0 && answer2 != 0 && answer3 != 0 && answer2 != 1 && answer2 != 2 && answer2 != 3 && answer2 != 4 )
            {
                Console.Write("Select Ingedients (0 - exit, 1 - Mushrooms, 2 - Chicken, 3 - Carrots, 4 - Potatoes): ");
                answer2 = int.Parse(Console.ReadLine());

                if (answer2 == 0)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else if (answer2 == 1)
                    recipe.ingredient = Ingredients.Mushrooms;
                else if (answer2 == 2)
                    recipe.ingredient = Ingredients.Chicken;
                else if (answer2 == 3)
                    recipe.ingredient = Ingredients.Carrots;
                else if (answer2 == 4)
                    recipe.ingredient = Ingredients.Potatoes;
            }

            while (answer1 != 0 && answer2 != 0 && answer3 != 0 && answer3 != 1 && answer3 != 2 && answer3 != 3)
            {
                Console.Write("Select Seasoning (0 - exit, 1 - Spicy, 2 - Salty, 3 - Sweet): ");
                answer3 = int.Parse(Console.ReadLine());

                if (answer3 == 0)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else if (answer3 == 1)
                    recipe.seasoning = Seasoning.Spicy;
                else if (answer3 == 2)
                    recipe.seasoning = Seasoning.Salty;
                else if (answer3 == 3)
                    recipe.seasoning = Seasoning.Sweet;
            }

            if(answer1 != 0 && answer2 != 0 && answer3 != 0)
                Console.WriteLine($"\nYou selected {recipe.food} {recipe.ingredient} {recipe.seasoning}.");
        }

        enum Food
        {
            Soup = 1,
            Stew,
            Gumbo
        }

        enum Ingredients
        {
            Mushrooms = 1,
            Chicken,
            Carrots,
            Potatoes
        }

        enum Seasoning
        {
            Spicy = 1,
            Salty,
            Sweet
        }
    }
}
