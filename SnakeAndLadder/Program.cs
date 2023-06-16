using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");
            PlayGame();
        }


        
        static void PlayGame()
        {
            //UC-01-Snake and Ladder game played with single player at start position 0
            int currentPosition = 0;
            int targetPosition = 100;
            Random random = new Random();

            while (currentPosition < targetPosition)
            {
                Console.WriteLine("Current Position: " + currentPosition);
                Console.WriteLine("Press any key to roll the dice...");
                Console.ReadKey();
                /* UC-02-The Player rolls the die to get a number between 1 to 6. 
                    - Use((RANDOM)) to get the number between 1 to 6
                */
                int diceValue = random.Next(1, 7);
                Console.WriteLine("You rolled a " + diceValue);

                if (currentPosition + diceValue <= targetPosition)
                    currentPosition += diceValue;

                currentPosition = HandleSnakeOrLadder(currentPosition);

                if (currentPosition == targetPosition)
                {
                    Console.WriteLine("Congratulations! You reached the target position.");
                    break;
                }
            }

            Console.WriteLine("Game Over!");
        }

        static int HandleSnakeOrLadder(int position)
        {
            switch (position)
            {
                case 4:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 2.");
                    return 2;
                case 9:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 7.");
                    return 7;
                case 17:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 5.");
                    return 5;
                case 20:
                    Console.WriteLine("Yay! You found a ladder. Going up to position 38.");
                    return 38;
                case 28:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 8.");
                    return 8;
                case 40:
                    Console.WriteLine("Yay! You found a ladder. Going up to position 59.");
                    return 59;
                case 52:
                    Console.WriteLine("Yay! You found a ladder. Going up to position 72.");
                    return 72;
                case 57:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 48.");
                    return 48;
                case 71:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 26.");
                    return 26;
                case 80:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 61.");
                    return 61;
                case 87:
                    Console.WriteLine("Yay! You found a ladder. Going up to position 93.");
                    return 93;
                case 93:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 66.");
                    return 66;
                case 95:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 75.");
                    return 75;
                case 98:
                    Console.WriteLine("Oops! You landed on a snake. Going down to position 64.");
                    return 64;
                default:
                    return position;
            }
        }
    }
}