//With the double forward slash I am able to write a comment in my code. This is a single line comment.

//WriteLine looks at our console and prints whatever is in the parentheses. The text must be in quotes or it will not work.
//WriteLines are considered Outputs.

//Console.Clear() clears the console of any text that was previously printed to it. This is useful if you want to start fresh with a new message or output.
Console.WriteLine("Stay Fresh, Cheese Bag!");


//Syntax is the set of rules that define how code should be written in a programming language. It includes things like the use of semicolons, brackets, and keywords. Following proper syntax is important for ensuring that your code runs correctly and is easy to read and understand.
//Syntax errors occur when the code does not follow the rules of the programming language, such as missing a semicolon or using an incorrect keyword. These errors prevent the code from compiling and running correctly, and must be fixed before the program can be executed.
Console.WriteLine("I want to eat some Chipotle!");

Console.WriteLine(5);

//"" shows a String (or text) data type. Strings are used to represent text in programming languages, and can include letters, numbers, symbols, and spaces. They are typically enclosed in double quotes to distinguish them from other data types like integers or booleans.
// 5 is an integer (whole number) data type. Integers are used to represent whole numbers in programming languages, and can be positive, negative, or zero. They are typically used for counting, indexing, and performing mathematical operations.

Console.WriteLine("Lets test this out!");
//Console.Write does not have a line break after the output, so any subsequent output will be printed on the same line and joined. This can be useful for creating prompts or messages that require user input, or for formatting output in a specific way.

//Variables are used to store data in programming languages. They can hold different types of data, such as numbers, text, or boolean values. Variables are typically declared with a name and a data type, and can be assigned a value that can be changed later in the program. They are useful for storing and manipulating data in a program, and can help make code more readable and maintainable.
//In C# variables have explicit data types, meaning that the type of data a variable can hold must be specified when it is declared. This helps prevent errors and makes the code easier to read and understand. C# also supports implicit typing, where the type of a variable is inferred from the value assigned to it, but this is less common and can lead to confusion if not used carefully.

string firstName = "Chris";
Console.WriteLine(firstName);

//Readline allows the user to input text within the console, code will wait for user input

Console.Clear ();

//Console.ReadLine ();

// string is changed to input then input is output,

Console.WriteLine("What is your favorite album?");

string myfavAlbum = Console.ReadLine ();

//Concatenation - the joining of two or more string (need to add space at end of string if creating a sentence)

Console.WriteLine("Oh wow I love " + myfavAlbum);

Console.Clear ();