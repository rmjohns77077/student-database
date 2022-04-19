public class Program
{
    static bool runagain;
    public static void Main()
    {
        var foods = new string[] { "pizza ", "hotdogs ", "Mac and Cheese ", "Tuna ", " Sushi ", "Arby's", "Lee's  ", "Fish ", "Tacos ", "Bernie O's " };
        var hometown = new string[] { "Detroit ", "Muskegon ", "Fruitport ", "Newaygo ", "Fremont ", "Rothbury ", "Ludington ", "Twin Lake ", "Muskegon ", "Whitehall " };
        var name = new string[] { "Ryan ", "Alecia ", "Scout ", "Shiah ", "Story ", " Hunter ", "Ha'nna ", "Olivia ", "Johnny ", "Kei " };
        do
        {
            Console.WriteLine("Select a number 1 through 10 to learn about a student");
            var nums = Console.ReadLine();
            int userInput = int.Parse(nums);
            Console.WriteLine($"This students name is {name[userInput - 1]}");

            Console.WriteLine("Would you like to see their favorite food or their hometown?");
            var choice = Console.ReadLine();
            if (choice == "food")
            {
                Console.WriteLine($"Favorite food is {foods[userInput - 1]}");
            }
            else
            {
                Console.WriteLine($"Their hometown is {hometown[userInput - 1]}");

            }
            do {
                Console.WriteLine("Would you like to learn about another student? y/n");
                choice = Console.ReadLine();

                if (choice == "y")
                {
                    runagain = true;
                }
                else if (choice == "n")
                {
                    runagain = false;

                }
                else
                {
                    Console.WriteLine("Im sorry try again");

                }
            } while (choice != "y" && choice != "n");
        } while (runagain); 
   
    }
}