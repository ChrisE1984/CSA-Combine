Console.Clear();
//Login FLow lecture using Classes, Methods, and Parameters.

//Prompt User for their Username 
//Prompt User for their Password

//We check if Username and Password are in the System "Database"

//User is found and return true and log them in

LoginSystem login = new LoginSystem();//initializing our new instance of our class into an object

Console.Write("Welcome, Please enter your username:");

string username = Console.ReadLine();

Console.Write("Please enter your password:");

string password = Console.ReadLine();

bool isLogin = login.CheckLogin(username, password);// username is being passed into our login check username method

if (isLogin)
{
    Console.WriteLine("Your login is successful.");
}
else
{
    Console.WriteLine("Username or password is incorrect.");
}
