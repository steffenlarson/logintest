using System;
using System.Collections.Generic;

namespace logintest
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(@"
      Hello This is the Login:
      
      ");


      Console.WriteLine(@"

      Press L to login or press N to create new login:
    
      ");

      Console.WriteLine("Create your loging username and password");

      // dictionary of type key type, value type 
      Dictionary<string, string> userPasswords = new Dictionary<string, string>(){
            {"steffen", "Dragon"}
        };

      Console.Write("Username: ");
      string username = Console.ReadLine();
      Console.Write("Password: ");
      string password = Console.ReadLine();

      userPasswords.Add(username, password);


      foreach (KeyValuePair<string, string> instance in userPasswords)
      {
        Console.WriteLine($"username: {instance.Key} - password: {instance.Value}");
      }

    }
  }
}
