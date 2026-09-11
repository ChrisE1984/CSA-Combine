//for loops, iteraters, decrementors, and string indexes

//A for loop is a loop that repeats a number of times
//++ means we are adding plus 1 to the value of our variable

//1. Variable
//2. Condition
//3. Way to break out of the loop

//1. initialization (int 1=0)
//2. condition (i < 5)
//3. iteration / decrement (i++)

//i stands for index or iteration

using System.Net;

for (int i=0; i < 5; i++)// the 3 steps inside the parentheses
{
    Console.WriteLine(i);
}
// -- is called the decrement operator

for(int i=5; i>0; i--)
{
    Console.WriteLine(i);
}

for(int i=1; i<6; i++)
{
    Console.WriteLine(i);
}

Console.Clear();

string name = "Isaiah";

Console.WriteLine(name[0]);

Console.WriteLine("Enter Y/N");

string userInput = Console.ReadLine();

Console.WriteLine (userInput[0]);

string username = Console.ReadLine();

int usernameLength = username.Length;

if(usernameLength > 5)
{
    Console.WriteLine("Name is too long, guy!");
}
else
{
    Console.WriteLine("Welcome in," + username );
}
Console.WriteLine();

// i want to create a for look that Iterates up until i reach the end of my user input
Console.Clear();

Console.WriteLine("What is your username?");

string input =Console.ReadLine();

for(int i = 0; i < username.Length; i++)
{
    Console.WriteLine(username[i]);
}

//+= addition operator
Console.Clear(); 
string nameTwo = "Jose";

nameTwo += "Martinez";

Console.WriteLine(nameTwo);
//expected output would be jose martinez

int score = 10;

score += 5;
Console.WriteLine(nameTwo);
Console.WriteLine(score);

//I want to create a for loop that adds a name to a different variable using the index only
string newName = "";

for (int i = 0; i < input.Length; i++)
{
    Console.WriteLine(i);
    newName += input[i];
    Console.WriteLine(newName);
}
System.Console.WriteLine(newName);