using System.IO.Pipelines;

public class LoginSystem
{
    //Fake Database

    List<string> database = ["Flysaiah", "Jacoozi", "Killa Cal", "King Zionn", "Brandon the Great"];

// since we are not using this method outside of our class this can be private
    public bool CheckUsername(string username)
    {
        Console.WriteLine($"Checking... for user {username}.");
        bool result;
    //     for(int i=0; i<database.Count; i++)
    //     {
    //         if (database[i]== username)
    //         Console.WriteLine("User found.");
    //     }
        
    // }

    // we are checking if our Database contains name, is so return true, else false
    if (database.Contains(username))// shorter for loop instead of above
    {
            result = true;
    }
        else
        {
            result = false;
        }

        return result;
}
//2 parameters as placeholders for username and password
public bool CheckLogin(string username, string password)
    {

        // we need to check if our user is in our DB && password is correct
        bool usernameVerified = CheckUsername(username);
        bool result;
        
        if (usernameVerified && password == "I Love Wingstop")
        
        {
         result = true;   
    }
        else
        {
            result = false;
        }
       return result;
}
}