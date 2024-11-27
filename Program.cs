// Example usage
using crude_login;

public class Program
{
    static void Main(string[] args)
    {
        // register an user
        Console.WriteLine(CrudeLogin.RegisterUser("ABCD", "1234"));

        // check login
        Console.WriteLine(CrudeLogin.LoginUser("ABCD", "1234"));

        // check login
        Console.WriteLine(CrudeLogin.LoginUser("EFGH", "5678"));

        // register an user
        Console.WriteLine(CrudeLogin.RegisterUser("EFGH", "5678"));

        // check login;
        Console.WriteLine(CrudeLogin.LoginUser("EFGH", "5678"));

        // check login with incorrect password;
        Console.WriteLine(CrudeLogin.LoginUser("EFGH", "1234"));

    }
}