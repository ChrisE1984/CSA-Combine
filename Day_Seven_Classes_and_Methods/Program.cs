Console.Clear();
//Classes and Methods

//A method is a block of code that performs a specific job
// instead of writing the same code over and over, we can put that code inside a method and call it whatever we need it

//static allows us to call the method without creating an object
//void means the method has no return
//SayHello() method
static void SayHello()
{
    Console.WriteLine("Hello World!");
}

SayHello();//needed to call or invoke method to run it

//A parameter (inside the parentheses) lets us send information into a method
//A parameter is a placeholder for a value

static void GreetingUser(string name)
{
    Console.WriteLine($"Hey {name}! What's up!");

}
//If a method has a parameter we must pss in a value that matches the datatype in order to use the method 
//(string needs to be string, int needs to be int, etc.)
GreetingUser("Chris");



//Parameters = variables waiting for information
//Arguments = actual information being sent went invoking

static void DisplayPlayer(string name, int rank)
{
    Console.WriteLine($"{name} is rank {rank}");
}

DisplayPlayer("Isaiah", 1);

// Not every method has to be void
//we use int, meaning the method will expect an integer return
static int AddNumbers(int NumberOne, int NumberTwo)
{
    int total = NumberOne+NumberTwo;

    return total;// return as sending information back, i.e. an integer
    
}

int answer = AddNumbers(2, 2);

Console.WriteLine(answer);

//This method sends off an integer
static int GetNumber()
{
    return 10;
}
// This method sends back a bool
static bool IsHotOutside()
{
    return true;
}
//This method sends back a string
static string GetName()
{
    return "Isaiah";
}


//A Class is a way to organize related code
//A Class is a blueprint of an object
//Object is an instance of a class

Random rnd = new Random();

GameMethods.GameGreeter();

string userInput = Console.ReadLine ();

GameMethods.GreetPlayer(userInput);

int totalDamage = GameMethods.DamageCalc(5, 10);

Console.WriteLine($"Your total damage dealt is {totalDamage}!");