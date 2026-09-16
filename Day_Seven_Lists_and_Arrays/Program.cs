using System.Collections.Concurrent;

Console.Clear();

//Arrays and Lists and recovering for loops

//Arrays are collections that allow you to store multiple values *of the same type*

string studentOne = "Valerie";
string studentTwo = "Chris";
string studentThree = "Brandon";

//data type/[]/ array name/ = / [];
string [] studentName = ["Chris", "Valerie", "Brandon"];//Arrays are fixed in length, cannot add additional indexes to an array 

studentName[0] = "Jaime";//Reassigning index 0 of the array
Console.WriteLine(studentName [1]);

string[] names = new string[3];// gives me an array with exactly 3 spaces

names [0]= "Isaiah";
names [1]= "Jacob";
names [2]= "Jose";


//initialization,condition,increment
for(int i = 0; i < names.Length; i++) 
{
    Console.WriteLine(names[i]);
}

//for each loop: this is used to cleanly read every item in a collection
//for loop is used when you want precise control over the indices or want to modify the collection structure


//clean and readable for reading data

//foreach(type thing in things){
//Console.WriteLine(thing);
//}

foreach(string name in names){
    Console.WriteLine(name);
}

int[] ages = [36,41,19,18,31,31];

foreach(int age in ages)
{
    Console.WriteLine(age);
}

//------------------------------------------------List-----------------------------------------------------------

//Arrays are fixed collections they cannot grow or shrink
//List are dynamic collections, they can shrink or grow


//List<data type> listName = [elements]
List<string> games = [];

games.Add("Chrono Trigger");
games.Add("Fallen Order");
games.Add("Valorant");

for(int i = 0; i<games.Count; i++){    //for List need to use .Count instead of .Length

    //i want to remove any game with a character count over 8
    if (games[i].Length>8)
    {
        Console.WriteLine(games[i]);
    }
foreach(string game in games)
{
    Console.WriteLine(game);
}
}

//To remove elements from a List we use the .Remove Method

games.Remove("Valorant");

foreach(string game in games)
{
    Console.WriteLine(game);
}

//----------------------------------------Collection Methods------------------------------------

//Arrays use .Length to tell us how many items they contain
Console.WriteLine(studentName.Length);

//List uses .Count

Console.WriteLine(games.Count);

//for both List and Arrays .Contains checks if the collection contains an an element and returns true if it exists

bool found = games.Contains("Fallen Order");
Console.WriteLine(found);

if (games.Contains("Chrono Trigger"))
{
    Console.WriteLine("Chrono Trigger is on the list");
}

//.Add allows to add to the end of our List
games.Add("League of Legends");

//.Remove allows us to remove the value, not the index
games.Remove("Fallen Order");

//.RemoveAt removes something using it's index
games.RemoveAt(1);

//.Clear erases everything from the list including the indices
games.Clear();

//.Insert adds an item to a specific index
games.Insert(0,"Modern Warfare 2");

Console.WriteLine(games[0]);
