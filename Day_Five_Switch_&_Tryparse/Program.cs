Console.Clear();

//Switch Statement & Tryparse Lecture

//int dayOfWeek = 2; // we're assuming everyone starts their week on monday so the 3 will represent Wednesday
//We are just checking weekdays

// Console.WriteLine("Hello please enter 1-5 based on what today is:");

// string userInput = Console.ReadLine();
// int dayOfWeek = Convert.ToInt32(userInput);

// switch (dayOfWeek)
// {
// case 1:
//     Console.WriteLine("Today is Monday.");
//     break;//This breaks us out of the block
// case 2:
//     Console.WriteLine("Today is Tuesday.");
//     break;
// case 3:
//     Console.WriteLine("Today is Wednesday.");
//     break;
// case 4:
//     Console.WriteLine("Today is Thursday.");
//     break;
// case 5:
//     Console.WriteLine("Today is Friday.");
//     break;
// default:
//     Console.WriteLine("Invalid day");
//     break;
// }

// Tryparse is used to covert strings into integers, if the conversion succeeds, 
// it returns true and then gives the converted, if it fails it returns false without throwing and exception


Console.WriteLine("Hello please enter 1-5 based on what today is:");

string userInput = Console.ReadLine();

int dayOfWeek;

//TryPars tries to convert the user input to an int
//The result is stored in our dayOfWeek int if the conversion happens successfully
bool success = int.TryParse(userInput, out dayOfWeek);

Console.WriteLine(success);

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Today is Monday.");
        break;//This breaks us out of the block
    case 2:
        Console.WriteLine("Today is Tuesday.");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday.");
        break;
    case 4:
        Console.WriteLine("Today is Thursday.");
        break;
    case 5:
        Console.WriteLine("Today is Friday.");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

//while loops example fo TryParse

Console.WriteLine("Enter a number: ");

string userNum = Console.ReadLine();

int num;
//TryParse requirements
//1.User input to parse
//2.variable to store conversion
//3.boolean variable to store true/false return
bool isConverted = int.TryParse(userNum, out num);
// if conversion is not successful, number will be 0
// if input is successfully converted then this code block will run

while (isConverted == false)
{
    //if conversion is false this codeblock will execute
    Console.WriteLine("You did not enter a number.");
    Console.WriteLine("Please enter a number.");

    userNum = Console.ReadLine();

    isConverted = int.TryParse(userNum, out num);
}

if (num < 10)
{
    Console.WriteLine("Your number is less than 10.");

}
else
{
    Console.WriteLine("Your number is greater than 10.");
}
