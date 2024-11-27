using System;
using System.Collections.Generic;

namespace crude_login;

public class CrudeLogin{
    public static Dictionary<string, string> login = new Dictionary<string, string>();

    public static string LoginUser(string userName, string password)
    {
        // check if a key already exists with that user name
        if (login.ContainsKey(userName) ){
             if (login[userName].Equals(password) ){
                return "Login successful";
             } else {
                return "Incorrect password";
             }
            
        } else {
            return "The user does not exist";
        }
    }
    public static string RegisterUser(string userName, string password)
    {
        // check if a key already exists with that user name
        if (login.ContainsKey(userName)){
            return "The user already exists";
        } else {
            login.Add(userName, password);
            return "The user added successfully";
        }
        
    }
}
