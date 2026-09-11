Console.Clear();
string playAgain;
do
{



//We are covering while loops with validation & do while loops

//1. a variable outside of the loop
//2. a condition
//3. a way to end the loop

Console.WriteLine("Would you like to play again? yes/no?");

//To.Lower is a method used on strings to convert all text to lowercase
string answer = Console.ReadLine().ToLower();

while (answer != "no" && answer != "yes")
{
    Console.WriteLine("Invalid answer. Please enter Yes or No");
    answer = Console.ReadLine().ToLower();
}

if (answer == "yes")
{
    Console.WriteLine("Let's keep playing.");

}
else
{
    Console.WriteLine("Thanks for playing! Stay fresh, Cheese Bag!");
}


Console.WriteLine("Continue? Y/N");

string input = Console.ReadLine().ToUpper();

while(input != "Y" && input != "N")
{
    Console.WriteLine("Invalid input, please enter Y or N.");
    input = Console.ReadLine().ToUpper();
}
if (input == "Y")
{
    Console.WriteLine("Another one!");
}
else
{
    Console.WriteLine("Go for a walk or sumthin then.");
}
Console.Clear();
//Do while loops will run at least once before the condition is checked

//do
//{
//This code block will run at least once
//}

do
{
    Console.WriteLine("Will this code run?");
    
} while(false);// while is outside of block

string playerAnswer;// declaring the variable 

do
{
    Console.WriteLine("Would you like to play again? YES/NO?");
    playerAnswer = Console.ReadLine().ToUpper(); 

} while (playerAnswer != "YES" && playerAnswer != "NO");

    Console.WriteLine("Would you like to learn again? y/n");
    playAgain = Console.ReadLine();

   while (playAgain != "y" && playAgain != "n") ;
    {
        Console.WriteLine("Invalid input, please enter y/n");
        playAgain = Console.ReadLine().ToLower();
    }

}while (playAgain == "y");