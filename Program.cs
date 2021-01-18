using System;

namespace GameBuy
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputData = Console.ReadLine(); // read info 
            string command = "Game Time";
            
            float gamePrice = 0f;
            float totalSpent = 0f;
            float budgetBalance = float.Parse(inputData);

            while (true)  // inputData != "Game Time" in this case to check inside the  while(inputData != "Game Time")
            {     
                string inputGame = Console.ReadLine();

                if (inputGame == command)
                {
                    Console.WriteLine($"Total spent: ${totalSpent}. Remaining: ${budgetBalance:F2}");
                    break;
                }

                if (inputGame == "OutFall 4")
                {
                    gamePrice = 39.99f;
                }
                else if (inputGame == "CS: OG" )
                {
                    gamePrice = 15.99f;
                }
                else if (inputGame == "Zplinter Zell")
                {
                    gamePrice = 19.99f;
                }
                else if (inputGame == "Honored 2")
                {
                    gamePrice = 59.99f;
                }
                else if (inputGame == "RoverWatch")
                {
                    gamePrice = 29.99f;
                }
                else if (inputGame == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99f;
                }
                else        // last if game is not listed above-> then game does not exist into our table
                {
                    Console.WriteLine("Not Found");
                    // if the game no present then we cotinue to choose an existing game 
                    continue;
                }
                // budgetBalance -= gamePrice;  // after every bought game we reduce with game price our budget
                // Console.WriteLine("Test");

                if (budgetBalance < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                    // continue;
                }
                else if (budgetBalance >= gamePrice)
                {
                    Console.WriteLine($"Bought {inputGame}");
                    budgetBalance -= gamePrice;
                    totalSpent += gamePrice;
                }

                if (budgetBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }
}
