using System;

partial class Program {
  public static void Main (string[] args) {

    
//    Random random = new Random();

    string[]  strings = Console.ReadLine().Split();

    Random random = new Random();
    string[]arr = strings.OrderBy(x => random.Next()).ToArray();


    foreach(string c in arr) {
      Console.WriteLine(c);

    }

    
  }
}

