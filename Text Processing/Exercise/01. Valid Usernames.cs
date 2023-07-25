using System;


class Program {
  public static void Main (string[] args) {   

    
    List<string> usernames = Console.ReadLine().Split(", ").ToList();
    string all  = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_";




    foreach(var username in usernames){

      if (username.Length < 4 || username.Length > 15){
        continue;
      }

      bool bool1 = false;

      foreach(var thing in username){

        if (!all.Contains(thing)){
          bool1 = true;
          break;
        }

      }

      if (bool1 == true){
        continue;
      }

      Console.WriteLine(username);




    }





  }
}
