// Caitlin Sheeran
// 1/27/2025
// Number Guessing Game
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            // while playAgain = true
            while (playAgain)
            {
                // sets the variables back to 0, blank, and picks a new random number
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max+1);


                // While the user guess does not equal the random number
                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    
                    //tells user if their guess is too high or too low
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");   
                    }
                    guesses++;

                }
                // Displays the number, winning message, and how many guesses it took
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!");
                Console.WriteLine("Guesses: "+ guesses);

                // asks the user if they want to play again
                Console.Write("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper(); //converts the input to an uppercase letter

                // you escape the while loop if answer does not equal Y
                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain= false;
                }

            }
            Console.WriteLine("Thanks for playing!");


            Console.ReadKey();
        }
    }
}
