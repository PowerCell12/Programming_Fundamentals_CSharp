using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int rows = int.Parse(Console.ReadLine());
    Dictionary<string, string> data= new Dictionary<string, string>();

    for(int i = 0; i < rows; i++) {

      List<string> commands = Console.ReadLine().Split().ToList();


      if (commands[0] == "register") {

        if (data.ContainsKey(commands[1])){ 
          
          Console.WriteLine($"ERROR: already registered with plate number {commands[2]}");

        }
        else{
          data[commands[1]] = commands[2];
          Console.WriteLine($"{commands[1]} registered {commands[2]} successfully");
        }

      }
      else{

        if (!data.ContainsKey(commands[1])){
          Console.WriteLine($"ERROR: user {commands[1]} not found");
        }
        else{
          data.Remove(commands[1]);
          Console.WriteLine($"{commands[1]} unregistered successfully");
        }
      }
    }


    foreach(KeyValuePair<string,string> pair in data){

      Console.WriteLine($"{pair.Key} => {pair.Value}");

    }


  }
}
