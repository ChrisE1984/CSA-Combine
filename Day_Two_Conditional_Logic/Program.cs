Console.Clear();

//This lecture will be on Conditional Statements (If and If Else) & Logical Operators

//bool is a true or false  statement or value

//1 
//bool isTrue = 1 > 2;
// < > <= => Comparison Operators that compare numbers and determine if the comparison is true or false
//Ids Jose = Isaiah
//== is an Equality Operator that checks if one value is equal or the same as another

//!= is an Inequality Operator that checks if one value is NOT equal to another
//bool isTrue = "Jose" != "Isaiah"

int age = 19;

//Because our condition is true the block after our "if" statement runs
if(age >= 18)
{
   Console.WriteLine("You are an Adult. Make better decisions"); 
}
else if (age >= 13)
{
    Console.WriteLine("You are a teenager, get off my lawn!");
}
else
{
    Console.WriteLine("You are still a preteen, where are your parents?!");

}


Console.WriteLine("Isaiah, Please Enter Your Banking Password:");

string password = Console.ReadLine();

if(password == "Chipotle1989")
{
    Console.WriteLine("Welcome Mr. Ferguson, We've Missed You!");
}
else
{
    Console.WriteLine("Wrong Password, and you get no more attempts, Goodbye!");
}

//Modulo Operator (%) this operator is used to find the remainder when one number is divided into another
//This is often used for checking odds or evens in programming

int result = 10 % 3;

Console.WriteLine(result);