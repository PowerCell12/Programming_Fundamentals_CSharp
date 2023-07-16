using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();

    foreach(string w in words) {
      Console.WriteLine(w);
    }



  }
}
