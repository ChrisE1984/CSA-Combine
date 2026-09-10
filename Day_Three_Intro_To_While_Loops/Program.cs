//While Loop Lecture

//A While Loop will repeatedly execute a block of code while its condition is true

//This is called an infinite look and it breaks your code
//This is also called a runtime error

//while (true)
//{
// Console.WriteLine("Does this thing stop?");
//}
Console.Clear();
string jacobsNum = "";

//Because our condition is initially true our loop runs.

while (jacobsNum != "123456789")
{
    Console.WriteLine("Please enter Jacob's Routing Number, I really need it bad");
    jacobsNum = Console.ReadLine() ?? "";
}

//Loops need 3 things to run
// Needs a variable outside of the While Loop
// A Condition with the variable
// We need a way to alter the variable to make the condition false

int counter = 0;// Globally Scoped Variable

while(counter < 5)
{
    Console.WriteLine(counter);
    //Adding one to our variable each time the loop is run.
    counter = counter + 1;
}

