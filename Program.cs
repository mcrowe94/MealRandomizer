using System.Security.Cryptography.X509Certificates;

namespace MealRandomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "y";

            Console.WriteLine("Welcome to your very own Meal Randomizer, where *I* do all the meal planning for you!");

            Console.WriteLine();

            do
            {


                Console.WriteLine("Here's a list of the days of the week! Please select a day...");
                List<string> daysOfTheWeek = new List<string>
               {"1. Monday", "2. Tuesday", "3. Wednesday", "4. Thursday", "5. Friday", "6. Saturday", "7. Sunday" };

                Random rng = new();
                List<string> dailyMeal = new List<string>
               {"Pizza!", "Grilled Chicken!", "Steaks!", "Spaghetti & Garlic Bread!", "Roast & Potatoes!", "Beef Stroganoff!", "Lasagna!", "Tacos!", "Hamburger Steaks & Gravy!", "Grilled Hotdogs!", "Breakfast!", "Sandwich Night!", "Fast Food restaurant of your choice!", "Dinner Date!", "Your choice crock pot meal!", "Chili Night!", "Veggie Soup!", "Lemon Pepper Chicken!", "Potato Soup!", "Pork Tenderloin!", "Enchiladas!", "Grilled Cheese & Your choice of soup!", "Beef Tips & Rice!", "Soup & Salad!" };

                var meal = dailyMeal[rng.Next(dailyMeal.Count())];

                foreach (var day in daysOfTheWeek)
                {
                    Console.WriteLine(day);

                }
                var userAnswer = Console.ReadLine();
                Console.WriteLine();





                switch (userAnswer)
                {
                    case "1":
                        Console.WriteLine($"Monday's meal is: {meal}");
                        break;
                    case "2":
                        Console.WriteLine($"Tuesday's meal is: {meal}");
                        break;
                    case "3":
                        Console.WriteLine($"Wednesday's meal is: {meal}");
                        break;
                    case "4":
                        Console.WriteLine($"Thursday's meal is: {meal}");
                        break;
                    case "5":
                        Console.WriteLine($"Friday's meal is: {meal}");
                        break;
                    case "6":
                        Console.WriteLine($"Saturday's meal is: {meal}");
                        break;
                    case "7":
                        Console.WriteLine($"Sunday's meal is: {meal}");
                        break;
                }

                Console.WriteLine("Would you like to run this again? Y/N.");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "n")
                {
                    Console.WriteLine("Now exiting");
                    Environment.Exit(0);
                }

            }
            while (userInput == "y");

            
        }
    }
}