//public is called an access modifier ti allows access to this class
public static class GameMethods
{
    // by default methods, variables, etc are set to private, we need to declare them public
    public static void GameGreeter()//static allows us to call the methods directly without creating an instance
    {
        Console.WriteLine("Welcome to the game.");
    }

    public static void GreetPlayer(string playerName)
    {
        Console.WriteLine($"Welcome {playerName}");
    }

    public static int DamageCalc(int numberOne, int NumberTwo)
    {
        int total;

        total = numberOne + NumberTwo;

        return total;

        //or return numberOne + NumberTwo
    }
}
