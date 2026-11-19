// Project requirements
// Generate a random number between 1 and 100.
// Ask the user to guess the number.
// Tell them whether their guess is too high or too low.
// Keep asking until they guess correctly.
// Display how many guesses they needed
    
namespace NumberGuessingGame
{
    public class NumberGuessingGame
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("The guess is from 1 - 100! I will let you know if you need to go higher or lower!");
            
            int answer = GenerateRandomNumber();
            
            bool gameFinished = true;

            int guessesNeeded = 0;

            while (gameFinished)
            {
                guessesNeeded++;
                
                string input = Console.ReadLine();

                if(int.TryParse(input, out int guess))
                {
                    if(guess < 1 || guess > 100)
                    {
                        Console.WriteLine("The number can only be from 1 - 100! No need to go out of bounds!");
                    }
    
                    if(answer == guess)
                    {
                        Console.WriteLine("Congrats! The correct answer was " + answer);
                        Console.WriteLine("You needed " + guessesNeeded + " guesses to get the correct number!");
                        
                        bool playAgain = PlayAgain();
                        
                        if(playAgain == true)
                        {
                            answer = GenerateRandomNumber();
                            guessesNeeded = 0;
                            gameFinished = true;
                        }

                        else
                        {
                            Console.WriteLine("Thank you so much for playing my game. ");
                            gameFinished = false;
                        }
                    }    

                    else if (answer < guess)
                    {
                        Console.WriteLine("Too high!");
                    }

                    else if (answer > guess)
                    {
                        Console.WriteLine("Too low!");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }                
            }
        }

        public static int GenerateRandomNumber()
        {
            Random RandomNumber = new Random();

            int number = RandomNumber.Next(1, 101);
            
            return number;
        }

        public static bool PlayAgain()
        {
            Console.WriteLine("Would you like to play again? (Y/N)");

            string? playAgain = Console.ReadLine();

            bool playAgainInput = true;

            while (playAgainInput)
            {
                if(playAgain.ToLower().Equals("y"))
                {
                    Console.WriteLine("Okay! New number is generated!");
                    Console.WriteLine("Guesses are back to 0! Guess a new number whenever.");
                    return true;
                }

                else if(playAgain.ToLower().Equals("n"))
                {
                    return false;
                }

                else
                {
                    Console.WriteLine("Please enter either Y or N.");
                    playAgain = Console.ReadLine();
                }
            }

            return false;
        }
    }
}