using System;
partial class Program {  
  public static void Main (string[] args)
    {

      List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();


      while (true){

        List<string> commands = Console.ReadLine().Split().ToList();


        if (commands[0] == "end"){
          break;
        }


        if (commands[0] == "Add"){

          numbers.Add(int.Parse(commands[1]));

        }
        else if (commands[0] == "Remove"){

          numbers.Remove(int.Parse(commands[1]));
        }
        else if (commands[0] == "RemoveAt"){

          numbers.RemoveAt(int.Parse(commands[1]));
  
        }
        else if (commands[0] == "Insert"){

          numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
        }
      }

      Console.WriteLine(string.Join(" ", numbers));



    }
}
