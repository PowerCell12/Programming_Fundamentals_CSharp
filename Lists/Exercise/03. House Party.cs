using System;
using System.Linq;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

  int lines = int.Parse(Console.ReadLine());
  List<string> names = new List<string>();
    
  for (int i =0; i < lines; i++){

    string[] commands = Console.ReadLine().Split();

    if (commands.Contains("not")){

      if (names.Contains(commands[0])){
        names.Remove(commands[0]);
      }
      else{
        Console.WriteLine($"{commands[0]} is not in the list!");
      }
      
    }
    else{

      if(!names.Contains(commands[0])){
        names.Add(commands[0]);
      }
      else{
          Console.WriteLine($"{commands[0]} is already in the list!");
      }
      
      
    }
    
  }
  Console.WriteLine(string.Join("\n", names));

    
  }
}
