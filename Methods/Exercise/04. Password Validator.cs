using System;

partial class Program {  
  public static void Main (string[] args) {    


    string password = Console.ReadLine(); 
    bool bool1 = true;
    bool bool2 = true;
    bool bool3 = true;

    if (6 > password.Length || password.Length > 10){
      Console.WriteLine("Password must be between 6 and 10 characters");
      bool1 = false;
    }


    foreach (char c in password){

      if (!char.IsLetterOrDigit(c)){
        Console.WriteLine("Password must consist only of letters and digits");
        bool2 = false;
        break;
      }
    }


    int counter = 0;
    foreach (char c in password){
      
      if (char.IsDigit(c)){
        counter++;
    }
    }

    if (counter < 2){
      Console.WriteLine("Password must have at least 2 digits");
      bool3 = false;
    }
  
    if (bool1 == true && bool2 == true && bool3 == true){
      Console.WriteLine("Password is valid");
    }

  }
}
