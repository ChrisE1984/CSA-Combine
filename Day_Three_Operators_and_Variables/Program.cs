//String variables store text
string username = "Isaiah1989";

//int stores whole numbers
int num = 2008;

//boolean can store only true or false
bool isHot = true;

//double can store decimals up to 17 digits
double pandaExpressMeal = 10.45;

//float data type store decimals as well but not extremely long decimals (f at end of value)
float tempurature = 101.15f;

//long can store up to 9 quintillion (int can store 2 trillion)
long worldPopulation = 8111111111;

// char data tyoe stores a single character
//must use single quote
char middleInitial = 'J';

//null means there is no current value
string firstName = "Jacob";
string lastName = "Ferguson";

//when setting a null you need a ? after the declare datatype
string? middleName = null;

Console.WriteLine(middleName);

//----------------------------------------------------------------------------------------------------------------//

//&& And logical operators checks if the combination of 2 conditions are true
Console.Clear();
int age = 18;

bool hasLicense = false;

//Check if this person  is 18 AND has their license


if (age >= 18 && hasLicense == true)
{
    Console.WriteLine("You can drive!");
}
else
{
    Console.WriteLine("You're ridin' dirrty, playa!");
}

//OR Logical Operator || and checks if at least One of the conditions are true

//checking if i can see an R rated movie

int ageTwo = 16;

bool hasParentsConsent = true;

//In order to see the movie i need to be 18 or need my parents consent

if (ageTwo >= 18 || hasParentsConsent) // can just use variable "hasParentsConsent" don't need to use == true
{
    Console.WriteLine("Have fun watching this R-Rated Movie!");
}
else
{
    Console.WriteLine("Get outta here, kid!");
}