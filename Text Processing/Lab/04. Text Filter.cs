using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {



    string[] banned = Console.ReadLine().Split(", ").ToArray();
    string final = Console.ReadLine();


    while (true) {
      bool bool1 = false;

      foreach (string s in banned) {

        if (final.Contains(s)) {
          bool1 = true;

          final = final.Replace(s, new string('*', s.Length));


        }

      }

      if (!bool1) {

        break;

      }


    }

    Console.WriteLine(string.Join(" ", final));



  }
}
