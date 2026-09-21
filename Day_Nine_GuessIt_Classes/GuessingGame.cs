public class GuessingGame
{
    public int secretNumber;

    public int guess;

    //non-static methods must be called within a new instance
    public void StartGame()
    {
        Random rnd = new Random();

        secretNumber = rnd.Next(1, 11);
        Console.WriteLine("Welcome to Guess It!!!");
        Console.WriteLine(secretNumber);
    }
// making the non-static bool allows it to act as a bool
    public bool MakeGuess()
    {
        Console.WriteLine("Guess a number between 1-10");

        return int.TryParse(Console.ReadLine(), out guess);

        
    }
    public void CheckGuess()
    {
        if (guess > secretNumber)
        {
            Console.WriteLine("Too high. Try again.");
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Too low. Try again.");
        }
        else
        {
                Console.WriteLine("You guessed it!");
        }
        }
    }

