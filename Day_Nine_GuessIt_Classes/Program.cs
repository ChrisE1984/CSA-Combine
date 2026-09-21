Console.Clear();
//TOday we are covering Non-Static Classes a& Methods
//Using guess it as an example

//What is a Class? - a Class is a blueprint of an object
//What is an object - object is an instance of a class

//we are creating a new instance of our Player class
Player player = new Player();

Console.WriteLine(player.name);

//------------------------Guess-----------------------------------------

Random rnd = new Random();

int secretNumber = rnd.Next(1,11);

int guess = 0;

Console.WriteLine("Welcome to Guess It!!");

while (guess != secretNumber)
{
    Console.WriteLine("Please select a number between 1-10.");

    bool success = int.TryParse(Console.ReadLine(), out guess);

    if (success)
    {
        //this is where our logic will execute if book is true
        if (guess > secretNumber)
        {
            Console.WriteLine("Your number was a little too high");
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Your number is low, try again");
        }
        else
        {
            Console.WriteLine("You guessed it");
        }
    }
    else
    {
        Console.WriteLine("Error: you've entered an invalid number.");
    }
}

GuessingGame gameOne = new GuessingGame();
//need to call value (gameOne) not class
gameOne.StartGame();
while(gameOne.guess != gameOne.secretNumber)
{
    bool didConvert = gameOne.MakeGuess();//conversion(.TryParse) check)

    if(didConvert == true){
        
        gameOne.CheckGuess();
    }
    else
    {
        Console.WriteLine("You didn't enter a number. Try again.");
    }
}
 
 
