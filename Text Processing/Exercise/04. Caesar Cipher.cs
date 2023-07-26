using System;

class Program {
  public static void Main (string[] args) {

    string text = Console.ReadLine();

    foreach(char t in text){


      int ascci =  (int) t;

      ascci += 3;
      
      char character = (char) ascci;

      Console.Write(character);
        
      
    }
  


    
  }
}
