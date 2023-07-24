using System;

class Program {
  public static void Main (string[] args) {

    while (true){

      string strings = Console.ReadLine();

      if (strings == "end"){
        break;
      }
      
      string new_string  = "";
    
      for (int i  = strings.Length - 1; i >= 0; i--){
        new_string += strings[i];
      } 

      Console.WriteLine($"{strings} = {new_string}");
    }

    
  }
}
