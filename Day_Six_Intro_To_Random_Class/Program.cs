Console.Clear();

//Random Class Lecture

//The Random Class allows us to generate a number at random.
// This can be used for games, coin flips, dice rolls, random events.

// We need the data type, name, and a value to store it in
string dice = "six";

//We are declaring a random object. Random is the class and random is the object
//similar to creating a variable to hold the Random Object
Random random;

//We are initializing our object (long way)
//random = new Random();

Random rnd = new Random();//Create a Random Object and store it inside the variable

//I know i can generate a random number with rnd. rndNext();


//Next method has 2 parameters, it can take in a maximum or (minimum & maximum)
// maximum number is included

int max = 15;
int min = 1;
//this generates numbers between 1-14
int randomNum = rnd.Next(min, max);

Console.WriteLine(randomNum);// creates random number 1112143570 

Console.WriteLine("Can you guess my number?");
Console.Write("Enter your number here:");

string number = Console.ReadLine();

bool success = int.TryParse (number, out int playerGuess);

if (success)
{
    if (randomNum == playerGuess)
    {
      Console.WriteLine("Wow you got it!");
    }
    else
    {
        Console.WriteLine(("Nice Try, but you guessed wrong."));
    }

}
