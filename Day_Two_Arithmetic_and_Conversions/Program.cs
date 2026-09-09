Console.Clear();
//This will be our intro to Arithmetic and Assignment Operators / Conversion Lecture


// We are able to store sums within a variable
// creating a variable and assigning value is Initializing it
int num = 4+4;
Console.WriteLine (num);

Console.WriteLine("Enter your Lucky Number:");
string luckyNumber = Console.ReadLine();
Console.WriteLine("And add your Crush's Lucky Number:");
string crushLuckyNumber = Console.ReadLine();

// because these are strings the plus sign concatenates instead of adding them creating a logic error
Console.WriteLine(luckyNumber + crushLuckyNumber);


// We will use the Convert class to access our INT32 and convert the string into an integer
int actualLuckyNum = Convert.ToInt32 (luckyNumber);

int actualCrushLuckyNum = Convert.ToInt32 (crushLuckyNumber);

Console.WriteLine(actualLuckyNum + actualCrushLuckyNum);
