using System;
partial class Program {  
  public static void Main (string[] args) {    

    string type = Console.ReadLine();

    if (type == "int"){
      int integer = int.Parse(Console.ReadLine());
      int final = GetFinal(integer);
      Console.WriteLine(final);
    }
    else if (type == "real"){
      double integer1 = double.Parse(Console.ReadLine());
      double final1 = GetFinalDouble(integer1);
      Console.WriteLine($"{final1:F2}");
    }
    else if (type == "string"){
      string strings1 = Console.ReadLine();
      string stringFinal = FinalString(strings1);
      Console.WriteLine(stringFinal);
    }
    }

  static int GetFinal(int integer) { 

    return integer * 2;
  }

  static double GetFinalDouble(double integer){


    return integer * 1.5;
  }
  static string FinalString(string strings){
    return "$" + strings + "$";
  }



  }
